using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;
using MySoft.OgrenciTakip.Common.Enums;
using DevExpress.XtraBars;
using MySoft.OgrenciTakip.UI.Win.UserControls.Controls;
using MySoft.OgrenciTakip.Bll.Interfaces;
using MySoft.OgrenciTakip.Model.Entities.Base;
using MySoft.OgrenciTakip.UI.Win.Functions;
using MySoft.OgrenciTakip.Common.Message;
using MySoft.OgrenciTakip.UI.Win.UserControl.Controls;
using MySoft.OgrenciTakip.UI.Win.UserControls.Grid;
using MySoft.OgrenciTakip.UI.Win.Interfaces;
using DevExpress.XtraPrinting.Native;
using MySoft.OgrenciTakip.Model.Entities.Base.Interfaces;
using DevExpress.XtraBars.Navigation;

namespace MySoft.OgrenciTakip.UI.Win.Forms.BaseForms
{
    public partial class BaseEditForm : RibbonForm
    {
        #region Variables

        private bool _formSablonKayitEdilecek;
        protected MyDataLayoutControl DataLayoutControl;
        protected MyDataLayoutControl[] DataLayoutControls;
        protected IBaseBll Bll;
        protected KartTuru BaseKartTuru;
        protected BaseEntity OldEntity;
        protected BaseEntity CurrentEntity;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;
        protected bool IsLoaded;
        protected bool KayitSonrasiFormuKapat = true;
        protected bool FarkiSubeIslemi;
        protected internal IslemTuru BaseIslemTuru;
        protected internal long Id;
        protected internal bool RefreshYapilacak;

        #endregion

        public BaseEditForm()
        {
            InitializeComponent();
        }

        protected void EventsLoad()
        {
            //ButtonEvent
            foreach (BarItem button in ribbonControl.Items)
                button.ItemClick += Button_ItemClick;

            //FormEvent
            LocationChanged += BaseEditForm_LocationChanged;
            SizeChanged += BaseEditForm_SizeChanged;
            Load += BaseEditForm_Load;
            FormClosing += BaseEditForm_FormClosing;
            Shown += BaseEditForm_Shown;

            void ControlEvents(Control control)
            {
                control.KeyDown += Control_KeyDown;
                control.GotFocus += Control_GotFocus;
                control.Leave += Control_Leave;
                control.Enter += Control_Enter;

                switch (control)
                {
                    case FilterControl edt:
                        edt.FilterChanged += Control_EditValueChanged;
                        break;

                    case ComboBoxEdit edt:
                        edt.EditValueChanged += Control_EditValueChanged;
                        edt.SelectedValueChanged += Control_SelectedValueChanged; 
                        break;

                    case MyButtonEdit edt:
                        edt.IdChanged += Control_IdChanged;
                        edt.EnabledChange += Control_EnabledChange;
                        edt.ButtonClick += Control_ButtonClick;
                        edt.DoubleClick += Control_DoubleClick;
                        break;

                    case BaseEdit edt:
                        edt.EditValueChanged += Control_EditValueChanged;
                        break;
                    case TabPane tab:
                        tab.SelectedPageChanged += Control_SelectedPageChanged;
                        break;
                }
            }

            if (DataLayoutControls == null)
            {
                if (DataLayoutControl == null) return;
                foreach (Control ctrl in DataLayoutControl.Controls)
                    ControlEvents(ctrl);
            }
            else
                foreach (var layout in DataLayoutControls)
                    foreach (Control ctrl in layout.Controls)
                        ControlEvents(ctrl);
        }

        private void SablonYukle()
        {
            Name.FormSablonYukle(this);
        }

        private void FarkiKaydet()
        {
            if (Messages.EvetSeciliEvetHayir("Bu Filtre Referans Alınarak Yeni Bir Filtre Oluşturulacaktır. Onaylıyor musnuz?", "Kayıt Onay") != DialogResult.Yes) return;

            BaseIslemTuru = IslemTuru.EntityInsert;
            Yukle();
            if (Kaydet(true))
                Close();
        }

        private void ButonGizleGoster()
        {
            ShowItems?.ForEach(X => X.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(X => X.Visibility = BarItemVisibility.Never);

        }

        private void GeriAl()
        {
            if (Messages.HayirSeciliEvetHayir("Yapılan Değişiklikler Geri Alınacaktır Onaylıyor usunuz ?", "Geri Al Onay") != DialogResult.Yes) return;

            if (BaseIslemTuru == IslemTuru.EntityUpdate)
                Yukle();
            else
                Close();
        }

        private bool Kaydet(bool kapanis)
        {
            bool KayitIslemi()
            {
                Cursor.Current = Cursors.WaitCursor;

                switch (BaseIslemTuru)
                {
                    case IslemTuru.EntityInsert:
                        if (EntityInsert())
                            return KayitSonrasiIslemler();
                        break;
                    case IslemTuru.EntityUpdate:
                        if (EntityUpdate())
                            return KayitSonrasiIslemler();
                        break;
                }

                bool KayitSonrasiIslemler()
                {
                    OldEntity = CurrentEntity;
                    RefreshYapilacak = true;
                    ButonEnabledDurum();

                    if (KayitSonrasiFormuKapat)
                        Close();
                    else
                        BaseIslemTuru = BaseIslemTuru == IslemTuru.EntityInsert ? IslemTuru.EntityUpdate : BaseIslemTuru;

                    return true;
                }

                return false;
            }

            var result = kapanis ? Messages.KapanisMesaj() : Messages.KayitMesaj();

            switch (result)
            {
                case DialogResult.Yes:
                    return KayitIslemi();
                case DialogResult.No:
                    if (kapanis)
                        btnKaydet.Enabled = false;
                    return true;
                case DialogResult.Cancel:
                    return false;
            }

            return false;
        }

        protected void SablonKaydet()
        {
            if (_formSablonKayitEdilecek)
                Name.FormSablonKaydet(Left, Top, Width, Height, WindowState);
        }

        protected virtual void TabloYukle() { }

        protected virtual void NesneyiKontrollereBagla() { }

        protected virtual void GuncelNesneOlustur() { }

        protected virtual void FiltreUygula() { }

        protected virtual void TaksitOlustur() { }

        protected virtual void BaskiOnIzleme() { }

        protected virtual void Yazdir() { }

        // Bir form da birden fazla tablo var ise tablo yükleme işlemi buradan yapılıyor
        protected virtual void BagliTabloYukle() { }

        protected virtual void SecimYap(object sender) { }

        // Bir form da birden fazla tablo var ise hatali giris kontrolu için bu fonksiyon kullanılıyor
        protected virtual bool BagliTabloHataliGirisKontrol() { return false; }

        // Bir form da birden fazla tablo var ise tablo kaydetmek için bufonksiyon kullanılıyor
        protected virtual bool BagliTabloKaydet() { return false; }

        protected virtual bool EntityInsert()
        {
            return ((IBaseGenelBll)Bll).Insert(CurrentEntity);
        }

        protected virtual bool EntityUpdate()
        {
            return ((IBaseGenelBll)Bll).Update(OldEntity, CurrentEntity);
        }

        protected virtual void EntityDelete()
        {
            if (!((IBaseCommonBll)Bll).Delete(OldEntity)) return;
            RefreshYapilacak = true;
            Close();
        }

        protected internal virtual void Yukle() { }

        protected internal virtual IBaseEntity ReturnEntity() { return null; }

        protected internal virtual void ButonEnabledDurum()
        {
            if (!IsLoaded) return;
            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGeriAl, btnSil, OldEntity, CurrentEntity);
        }



        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (e.Item == btnYeni)
            {
                // Yetki Kontrolü
                BaseIslemTuru = IslemTuru.EntityInsert;
                Yukle();
            }
            else if (e.Item == btnKaydet)
            {
                Kaydet(false);
            }
            else if (e.Item == btnFarkiKaydet)
            {
                // Yetki kontrolü
                FarkiKaydet();
            }
            else if (e.Item == btnGeriAl)
            {
                GeriAl();
            }
            else if (e.Item == btnSil)
            {
                //Yetki Kontrolü
                EntityDelete();
            }

            else if (e.Item == btnUygula)
                FiltreUygula();

            else if (e.Item == btnTaksitOlustur)
                TaksitOlustur();

            else if (e.Item == btnYazdir)
                Yazdir();

            else if (e.Item == btnBaskiOnIzleme)
                BaskiOnIzleme();

            else if (e.Item == btnCikis)
            {
                Close();
            }
            Cursor.Current = DefaultCursor;
        }

        private void BaseEditForm_LocationChanged(object sender, EventArgs e)
        {
            _formSablonKayitEdilecek = true;
        }

        private void BaseEditForm_SizeChanged(object sender, EventArgs e)
        {
            _formSablonKayitEdilecek = true;
        }

        private void BaseEditForm_Load(object sender, EventArgs e)
        {
            IsLoaded = true;
            GuncelNesneOlustur();
            SablonYukle();
            ButonGizleGoster();

            if (FarkiSubeIslemi)
                Messages.UyariMesaji("İşlem Yapılan Kart Çalışılan Şube Veya Dönemde Olmadığı İçin Yapılan Değişiklikler Kayit Edilemez.");
        }

        protected virtual void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SablonKaydet();

            if (btnKaydet.Visibility == BarItemVisibility.Never || !btnKaydet.Enabled) return;
            if (!Kaydet(true))
                e.Cancel = true;
        }

        // Form Gösterildiğinde Tetiklenir
        protected virtual void BaseEditForm_Shown(object sender, EventArgs e) { }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();

            if (sender is MyButtonEdit edt)
                switch (e.KeyCode)
                {
                    case Keys.Delete when e.Control && e.Shift:
                        edt.Id = null;
                        edt.EditValue = null;
                        break;

                    case Keys.F4:
                    case Keys.Down when e.Modifiers == Keys.Alt:
                        SecimYap(edt);
                        break;
                }
        }

        private void Control_GotFocus(object sender, EventArgs e)
        {
            var type = sender.GetType();

            if (type == typeof(MyButtonEdit) || type == typeof(MyGridView) || type == typeof(MyPictureEdit) || type == typeof(MyComboBoxEdit) || type == typeof(MyDateEdit) || type == typeof(MyCalcEdit))
            {
                statusBarKisaYol.Visibility = BarItemVisibility.Always;
                statusBarKisayolAciklama.Visibility = BarItemVisibility.Always;

                statusBarAciklama.Caption = ((IStatusBarAciklama)sender).StatusBarAciklama;
                statusBarKisaYol.Caption = ((IStatusBarKisaYol)sender).StatusBarKisaYol;
                statusBarKisayolAciklama.Caption = ((IStatusBarKisaYol)sender).StatusBarKisaYolAciklama;
            }
            else if (sender is IStatusBarAciklama ctrl)
                statusBarAciklama.Caption = ctrl.StatusBarAciklama;
        }

        private void Control_Leave(object sender, EventArgs e)
        {
            statusBarKisaYol.Visibility = BarItemVisibility.Never;
            statusBarKisayolAciklama.Visibility = BarItemVisibility.Never;
        }

        protected virtual void Control_Enter(object sender, EventArgs e) { }

        protected virtual void Control_EditValueChanged(object sender, EventArgs e)
        {
            if (!IsLoaded) return;
            GuncelNesneOlustur();
        }

        protected virtual void Control_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e) { }

        // Seçili Kontrolun Valuesi Değiştiğinde Tetiklenir
        protected virtual void Control_SelectedValueChanged(object sender, EventArgs e) { }

        protected virtual void Control_IdChanged(object sender, IdChangedEventArgs e)
        {
            if (!IsLoaded) return;
            GuncelNesneOlustur();
        }

        protected virtual void Control_EnabledChange(object sender, EventArgs e) { }

        private void Control_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SecimYap(sender);
        }

        private void Control_DoubleClick(object sender, EventArgs e)
        {
            SecimYap(sender);
        }
    }
}