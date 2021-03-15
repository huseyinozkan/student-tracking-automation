using DevExpress.DataProcessing;
using DevExpress.XtraBars;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using MySoft.OgrenciTakip.Bll.General;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Common.Functions;
using MySoft.OgrenciTakip.Common.Message;
using MySoft.OgrenciTakip.Model.Dto;
using MySoft.OgrenciTakip.Model.Entities;
using MySoft.OgrenciTakip.UI.Win.Forms.BaseForms;
using MySoft.OgrenciTakip.UI.Win.Forms.RaporForms;
using MySoft.OgrenciTakip.UI.Win.Functions;
using MySoft.OgrenciTakip.UI.Win.Reports.XtraReports.Tahakkuk;
using MySoft.OgrenciTakip.UI.Win.Show;
using MySoft.OgrenciTakip.UI.Win.UserControls.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MySoft.OgrenciTakip.UI.Win.GenelForm
{
    public partial class RaporSecim : BaseListForm
    {
        private readonly OgrenciR _ogrenciBilgileri;
        private readonly IEnumerable<IletisimBilgileriR> _iletisimBilgileri;
        private readonly IEnumerable<HizmetBilgileriR> _hizmetBilgileri;
        private readonly IEnumerable<IndirimBilgileriR> _indirimBilgileri;
        private readonly IEnumerable<OdemeBilgileriR> _odemeBilgileri;
        private readonly IEnumerable<GeriOdemeBilgileriR> _geriOdemeBilgileri;

        public RaporSecim(params object[] prm)
        {
            InitializeComponent();
            Bll = new RaporBll();

            ShowItems = new BarItem[] { btnYeniRapor, btnBaskiOnizleme };
            HideItems = new BarItem[] { btnYeni, btnSec, btnFiltrele, btnKolonlar, barFiltrele, barFiltreleAciklama, barKolonlar, barKolonlarAciklama };

            btnDuzelt.CreateDropDownMenu(new BarItem[] { btnTasarimDegistir });
            btnYazdir.CreateDropDownMenu(new BarItem[] { btnTabloYazdir });

            txtYazciAdi.Properties.Items.AddRange(GeneralFunctions.YazicilariListele());
            txtYazciAdi.EditValue = GeneralFunctions.DefaultYazici();
            txtYazdirmaSekli.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YazdirmaSekli>());
            txtYazdirmaSekli.SelectedItem = YazdirmaSekli.TekTekYazdir.ToName();

            _ogrenciBilgileri = (OgrenciR)prm[0];
            _iletisimBilgileri = (IEnumerable<IletisimBilgileriR>)prm[1];
            _hizmetBilgileri = (IEnumerable<HizmetBilgileriR>)prm[2];
            _indirimBilgileri = (IEnumerable<IndirimBilgileriR>)prm[3];
            _odemeBilgileri = (IEnumerable<OdemeBilgileriR>)prm[4];
            _geriOdemeBilgileri = (IEnumerable<GeriOdemeBilgileriR>)prm[5];
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Rapor;
            Navigator = smallNavigator.Navigator;
        }

        protected override void Listele()
        {
            RowSelect?.ClearSelection();
            Tablo.GridControl.DataSource = ((RaporBll)Bll).List(FilterFunctions.Filter<Rapor>(AktifKartlariGoster));
        }

        protected override void Duzelt()
        {
            if (Messages.RaporTasarimaGonderMesaj() != System.Windows.Forms.DialogResult.Yes) return;
            
            Cursor.Current = Cursors.WaitCursor;
            
            var row = Tablo.GetRow<RaporL>();
            if (row == null) return;

            var entity = (Rapor)((RaporBll)Bll).Single(x => x.Id == row.Id);
            var result = ShowRibbonForms<RaporTasarim>.ShowDialogForm(KartTuru.RaporTasarim, entity);
            ShowEditFormDefault(result);

            Cursor.Current = DefaultCursor;
        }

        protected override void showEditForm(long id)
        {
            var row = Tablo.GetRow<RaporL>();
            if (row == null) return;

            var entity = (Rapor)((RaporBll)Bll).Single(x => x.Id == row.Id);

            var result = ShowEditForms<RaporEditForm>.ShowDialogEditForm(KartTuru.Rapor, id, entity.RaporTuru, entity.RaporBolumTuru, entity.Dosya);
            ShowEditFormDefault(result);
        }

        private IList<MyXtraReport> RaporHazirla()
        {
            var raporlar = new List<MyXtraReport>();

            var topluRapor = new MyXtraReport();
            topluRapor.CreateDocument();
            topluRapor.Baslik = "Toplu Rapor";
            topluRapor.PrintingSystem.ContinuousPageNumbering = false;

            foreach (var row in RowSelect.GetSelectedRows())
            {
                var entity = (Rapor)((RaporBll)Bll).Single(x => x.Id == row.Id);
                var rapor = entity.Dosya.ByteToStream().StreamToReport();
                ReportDataSource(rapor);
                rapor.CreateDocument();

                switch (txtYazdirmaSekli.Text.GetEnum<YazdirmaSekli>())
                {
                    case YazdirmaSekli.TekTekYazdir:
                        raporlar.Add(rapor);
                        break;
                    case YazdirmaSekli.TopluYazdir:
                        topluRapor.Pages.AddRange(rapor.Pages);
                        break;
                }
            }

            if (topluRapor.Pages.Count == 0) return raporlar;
            raporlar.Add(topluRapor);

            return raporlar;
        }

        private void ReportDataSource(IReport rapor)
        {
            switch (rapor)
            {
                case OgrenciKartiRaporu rpr:
                    rpr.Ogrenci_Bilgileri.DataSource = _ogrenciBilgileri;
                    rpr.Iletisim_Bilgileri.DataSource = _iletisimBilgileri;
                    rpr.Hizmet_Bilgileri.DataSource = _hizmetBilgileri;
                    rpr.Indirim_Bilgileri.DataSource = _indirimBilgileri.GroupBy(x=>new { x.IndirimAdi, x.IptalTarihi, x.IslemTarihi })
                        .Select(x=>new 
                        {
                            x.Key.IndirimAdi,
                            x.Key.IptalTarihi,
                            x.Key.IslemTarihi,
                            BrutIndirim = x.Sum(y=>y.BrutIndirim),
                            KistDonemDusulenIndirim = x.Sum(y=>y.KistDonemDusulenIndirim),
                            NetIndirim = x.Sum(y=>y.NetIndirim)
                        });
                    rpr.Odeme_Bilgileri.DataSource = _odemeBilgileri;
                    rpr.Geri_Odeme_Bilgileri.DataSource = _geriOdemeBilgileri;
                    break;

                case BankaOdemePlanRaporu rpr:
                    rpr.Ogrenci_Bilgileri.DataSource = _ogrenciBilgileri;
                    var secilenOdemeler = _odemeBilgileri.Where(x => x.OdemeTipi == OdemeTipi.Ots);
                    rpr.toplamTutarYazi.Text = secilenOdemeler.Sum(x => x.Tutar).YaziIleTutar();
                    rpr.Odeme_Bilgileri.DataSource = secilenOdemeler;
                    break;
            }
        }

        protected override void Yazdir()
        {
            if (Messages.EvetSeciliEvetHayir("Rapor Yazdırılmak Üzere Seçtiğiniz Yazıcıya Gönderilecektir Onaylıyor musunuz?", "Onay") != DialogResult.Yes) return;
            var raporlar = RaporHazirla();

            for (int i = 0; i < txtYazdirilacakAdet.Value; i++)
                raporlar.ForEach(x => x.Print(txtYazciAdi.Text));
        }

        protected override void BaskiOnizleme()
        {
            var raporlar = RaporHazirla();
            raporlar.ForEach(x => ShowRibbonForms<RaporOnizleme>.ShowForm(true, x.PrintingSystem, x.Baslik));
        }

        protected override void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            base.Button_ItemClick(sender, e);

            void RaporOlustur(KartTuru raporTuru, RaporBolumTuru raporBolumTuru, XtraReport rapor)
            {
                if (Messages.RaporTasarimaGonderMesaj() != DialogResult.Yes) return;

                Cursor.Current = Cursors.WaitCursor;
                var entity = new Rapor
                {
                    Kod = ((RaporBll)Bll).YeniKodVer(x => x.RaporTuru == raporTuru),
                    RaporTuru = raporTuru,
                    RaporBolumTuru = raporBolumTuru,
                    RaporAdi = raporTuru.ToName(),
                    Dosya = rapor.ReportToStream().GetBuffer(),
                    Durum = true
                };

                var result = ShowRibbonForms<RaporTasarim>.ShowDialogForm(KartTuru.RaporTasarim, entity);
                ShowEditFormDefault(result);

                Cursor.Current = DefaultCursor;
            }

            if (e.Item == btnYeniRapor)
            {
                var link = (BarSubItemLink)e.Item.Links[0];
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();
            }

            else if (e.Item == btnOgrenciKarti)
                RaporOlustur(KartTuru.OgrenciKartiRaporu, RaporBolumTuru.TahakkukRaporlari, new OgrenciKartiRaporu());

            else if (e.Item == btnBankaOdemePlani)
                RaporOlustur(KartTuru.BankaOdemePlaniRaporu, RaporBolumTuru.TahakkukRaporlari, new BankaOdemePlanRaporu());

        }
    }
}