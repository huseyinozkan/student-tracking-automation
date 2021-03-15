﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using MySoft.OgrenciTakip.Bll.Interfaces;
using MySoft.OgrenciTakip.Common.Message;
using MySoft.OgrenciTakip.Model.Entities.Base;
using MySoft.OgrenciTakip.Model.Entities.Base.Interfaces;
using MySoft.OgrenciTakip.UI.Win.Forms.BaseForms;
using MySoft.OgrenciTakip.UI.Win.Functions;
using MySoft.OgrenciTakip.UI.Win.Interfaces;

namespace MySoft.OgrenciTakip.UI.Win.UserControls.UserControl.Base
{
    public partial class BaseTablo : XtraUserControl
    {
        private bool _isLoaded;
        private bool _tabloSablonKayitEdilecek;
        protected internal GridView Tablo;
        protected internal bool TableValueChanged;
        protected internal BaseEditForm OwnerForm;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;
        protected IBaseBll Bll;
        protected IList<long> ListeDisiTutulacakKayitlar;

        public BaseTablo()
        {
            InitializeComponent();
        }

        protected void EventLoad()
        {
            //Button Events
            foreach (BarItem button in barManager.Items)
            {
                button.ItemClick += Button_ItemClick;
            }

            //Tablodaki Colomlara Event Ataması
            foreach (GridColumn column in Tablo.Columns)
            {
                if (column.ColumnEdit == null) continue;
                var type = column.ColumnEdit.GetType();

                if(type == typeof(RepositoryItemImageComboBox))
                    ((RepositoryItemImageComboBox)column.ColumnEdit).SelectedValueChanged += ImageComboBox_SelectedValueChanged;

                if(type == typeof(RepositoryItemCheckEdit))
                    ((RepositoryItemCheckEdit)column.ColumnEdit).CheckedChanged += CheckEdit_CheckedChanged;
            }

            //Navigator Events
            insUptNavigator.Navigator.ButtonClick += Navigator_ButtonClick;

            //Table Events
            Tablo.CellValueChanged += Tablo_CellValueChanged;
            Tablo.MouseUp += Tablo_MouseUp;
            Tablo.GotFocus += Tablo_GotFocus;
            Tablo.LostFocus += Tablo_LostFocus;
            Tablo.KeyDown += Tablo_KeyDown;
            Tablo.FocusedColumnChanged += Tablo_FocusedColumnChanged;
            Tablo.ColumnPositionChanged += Tablo_SablonChanged;
            Tablo.ColumnWidthChanged += Tablo_SablonChanged;
            Tablo.EndSorting += Tablo_SablonChanged;
            Tablo.DoubleClick += Tablo_DoubleClick;
            Tablo.FocusedRowObjectChanged += Tablo_FocusedRowObjectChanged;
            Tablo.RowCountChanged += Tablo_RowCountChanged;

        }

        private void SablonKaydet()
        {
            if (_tabloSablonKayitEdilecek)
                Tablo.TabloSablonKaydet(Tablo.ViewCaption);
        }

        private void SablonYukle()
        {
            Tablo.TabloSablonYukle(Tablo.ViewCaption);
        }

        private void ButonGizleGoster()
        {
            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
        }

        protected void ButonEnabledDurum(bool durum)
        {
            TableValueChanged = durum;
            OwnerForm.ButonEnabledDurum();
        }

        protected internal void Yukle()
        {
            _isLoaded = true;
            TableValueChanged = false;
            OwnerForm.ButonEnabledDurum();
            insUptNavigator.Navigator.NavigatableControl = Tablo.GridControl;
            SablonYukle();
            Listele();
            ButonGizleGoster();
            Tablo_LostFocus(Tablo, EventArgs.Empty);
        }

        protected internal bool Kaydet()
        {
            var source = Tablo.DataController.ListSource;

            var insert = source.Cast<IBaseHareketEntity>().Where(x => x.Insert && !x.Delete).Cast<BaseHareketEntity>().ToList();
            var update = source.Cast<IBaseHareketEntity>().Where(x => x.Update && !x.Delete).Cast<BaseHareketEntity>().ToList();
            var delete = source.Cast<IBaseHareketEntity>().Where(x => x.Delete && !x.Insert).Cast<BaseHareketEntity>().ToList();

            if (insert.Any())
                if (!((IBaseHareketGenelBll)Bll).Insert(insert))
                {
                    Messages.HataMesaji($"{Tablo.ViewCaption} Tablosundaki Hareketler Eklenemedi.");
                    return false;
                }
            if (update.Any())
                if (!((IBaseHareketGenelBll)Bll).Update(update))
                {
                    Messages.HataMesaji($"{Tablo.ViewCaption} Tablosundaki Hareketler Güncellenemedi.");
                    return false;
                }
            if (delete.Any())
                if (!((IBaseHareketGenelBll)Bll).Delete(delete))
                {
                    Messages.HataMesaji($"{Tablo.ViewCaption} Tablosundaki Hareketler Silinemedi.");
                    return false;
                }

            ButonEnabledDurum(false);
            return true;
        }

        protected virtual void Listele() { }

        protected virtual void HareketEkle() { }

        protected virtual void HareketSil()
        {
            if (Tablo.DataRowCount == 0) return;
            if (Messages.SilMesaj("İşlem Satırı") != DialogResult.Yes) return;

            Tablo.GetRow<IBaseHareketEntity>().Delete = true;
            Tablo.RefreshDataSource();
            ButonEnabledDurum(true);
        }
        
        protected virtual void OpenEntity() { }

        protected virtual void SutunGizleGoster() { }

        protected virtual void RowCellAllowEdit() { }

        protected virtual void IptalEt() { }

        protected virtual void IptalGeriAl() { }

        protected virtual void BelgeHareketleri() { }

        protected internal virtual bool HataliGiris() { return false; }



        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item == btnHareketEkle)
                HareketEkle();

            else if (e.Item == btnHareketSil)
                HareketSil();

            else if (e.Item == btnKartDuzenle)
                OpenEntity();

            else if (e.Item == btnIptalEt)
                IptalEt();

            else if (e.Item == btnIptalGeriAl)
                IptalGeriAl();

            else if (e.Item == btnBelgeHareketleri)
                BelgeHareketleri();

            Cursor.Current = DefaultCursor;
        }

        protected virtual void ImageComboBox_SelectedValueChanged(object sender, EventArgs e) { }

        protected virtual void CheckEdit_CheckedChanged(object sender, EventArgs e) { }

        private void Navigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button == insUptNavigator.Navigator.Buttons.Append)
                HareketEkle();
            else if (e.Button == insUptNavigator.Navigator.Buttons.Remove)
                HareketSil();

            if (e.Button == insUptNavigator.Navigator.Buttons.Append || e.Button == insUptNavigator.Navigator.Buttons.Remove)
                e.Handled = true;
        }

        protected virtual void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (!_isLoaded) return;

            var entity = Tablo.GetRow<IBaseHareketEntity>();
            if (!entity.Insert)
                entity.Update = true;

            ButonEnabledDurum(true);
        }

        protected virtual void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            if (popupMenu == null) return;
            if (e.Button != MouseButtons.Right) return;

            btnHareketSil.Enabled = Tablo.RowCount > 0;
            btnKartDuzenle.Enabled = Tablo.RowCount > 0;
            btnIptalEt.Enabled = Tablo.RowCount > 0;
            btnIptalGeriAl.Enabled = Tablo.RowCount > 0;

            e.SagMenuGoster(popupMenu);
        }

        private void Tablo_GotFocus(object sender, EventArgs e)
        {
            OwnerForm.statusBarKisaYol.Visibility = BarItemVisibility.Always;
            OwnerForm.statusBarKisayolAciklama.Visibility = BarItemVisibility.Always;

            OwnerForm.statusBarAciklama.Caption = ((IStatusBarKisaYol)sender).StatusBarAciklama;
            OwnerForm.statusBarKisaYol.Caption = ((IStatusBarKisaYol)sender).StatusBarKisaYol;
            OwnerForm.statusBarKisayolAciklama.Caption = ((IStatusBarKisaYol)sender).StatusBarKisaYolAciklama;
        }

        private void Tablo_LostFocus(object sender, EventArgs e)
        {
            OwnerForm.statusBarKisaYol.Visibility = BarItemVisibility.Never;
            OwnerForm.statusBarKisayolAciklama.Visibility = BarItemVisibility.Never;
        }

        private void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    if (Tablo.IsEditorFocused)
                        insUptNavigator.Navigator.Buttons.DoClick(insUptNavigator.Navigator.Buttons.CancelEdit);
                    else
                        OwnerForm.Close();
                    break;

                case Keys.Tab:
                case Keys.Left:
                case Keys.Right:
                case Keys.Up:
                case Keys.Down:
                    insUptNavigator.Navigator.Buttons.DoClick(insUptNavigator.Navigator.Buttons.EndEdit);
                    break;

                case Keys.Insert when e.Shift:
                    HareketEkle();
                    break;
                case Keys.Delete when e.Modifiers == Keys.Shift:
                    HareketSil();
                    break;
                case Keys.F3:
                    OpenEntity();
                    break;
                case Keys.T when e.Control:
                    IptalEt();
                    break;
                case Keys.R when e.Control:
                    IptalGeriAl();
                    break;
                case Keys.F6:
                    BelgeHareketleri();
                    break;
            }
        }

        protected virtual void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            if (OwnerForm == null) return;
            OwnerForm.statusBarKisaYol.Visibility = BarItemVisibility.Never;
            OwnerForm.statusBarKisayolAciklama.Visibility = BarItemVisibility.Never;

            if (!e.FocusedColumn.OptionsColumn.AllowEdit)
                Tablo_GotFocus(sender, null);
            else if(((IStatusBarKisaYol)e.FocusedColumn).StatusBarKisaYol!=null)
            {
                OwnerForm.statusBarKisaYol.Visibility = BarItemVisibility.Always;
                OwnerForm.statusBarKisayolAciklama.Visibility = BarItemVisibility.Always;

                OwnerForm.statusBarAciklama.Caption = ((IStatusBarKisaYol)e.FocusedColumn).StatusBarAciklama;
                OwnerForm.statusBarKisaYol.Caption = ((IStatusBarKisaYol)e.FocusedColumn).StatusBarKisaYol;
                OwnerForm.statusBarKisayolAciklama.Caption = ((IStatusBarKisaYol)e.FocusedColumn).StatusBarKisaYolAciklama;
            }

            else if(((IStatusBarKisaYol)e.FocusedColumn).StatusBarAciklama != null)
                OwnerForm.statusBarAciklama.Caption = ((IStatusBarKisaYol)e.FocusedColumn).StatusBarAciklama;
        }

        private void Tablo_SablonChanged(object sender, EventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
        }

        private void Tablo_DoubleClick(object sender, EventArgs e)
        {
            OpenEntity();
        }

        private void Tablo_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e)
        {
            // Rowları dolaşırken çalışır. RowChanged 'dan farkı : rowdaki veri aynı olduğunda tetiklenmez.
            SutunGizleGoster();
            RowCellAllowEdit();
        }

        protected virtual void Tablo_RowCountChanged(object sender, EventArgs e) { }
    }
}
