using MySoft.OgrenciTakip.UI.Win.Forms.BaseForms;
using DevExpress.XtraBars;
using MySoft.OgrenciTakip.Common.Functions;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.UI.Win.Functions;
using MySoft.OgrenciTakip.Model.Entities.Base.Interfaces;
using MySoft.OgrenciTakip.Model.Entities;
using System;

namespace MySoft.OgrenciTakip.UI.Win.GenelForm
{
    public partial class TabloDokumParametreleri : BaseEditForm
    {
        private DokumSekli _dokumSekli;
        private readonly string _RaporBaslik;

        public TabloDokumParametreleri(params object[] prm)
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl2;
            HideItems = new BarItem[] { btnYeni, btnKaydet, btnGeriAl, btnSil} ;
            ShowItems = new BarItem[] { btnYazdir, btnBaskiOnIzleme };
            EventsLoad();

            _RaporBaslik = prm[0].ToString();
        }

        protected internal override void Yukle()
        {
            txtRaporBasligi.Text = _RaporBaslik;
            txtBaslikEkle.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            txtRaporuKagidaSigdir.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<RaporuKagidaSıgdırmaTuru>());
            txtYazdirmaYonu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YazdirmaYonu>());
            txtYatayCizgileriGoster.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            txtDikeyCizgileriGoster.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            txtSutunBasliklariniGoster.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            txtYaziciAdi.Properties.Items.AddRange(GeneralFunctions.YazicilariListele());

            txtBaslikEkle.SelectedItem = EvetHayir.Evet.ToName();
            txtRaporuKagidaSigdir.SelectedItem = RaporuKagidaSıgdırmaTuru.YaziBoyutunuKuculterekSıgdır.ToName();
            txtYazdirmaYonu.SelectedItem = YazdirmaYonu.Otomatik.ToName();
            txtYatayCizgileriGoster.SelectedItem = EvetHayir.Evet.ToName();
            txtDikeyCizgileriGoster.SelectedItem = EvetHayir.Evet.ToName();
            txtSutunBasliklariniGoster.SelectedItem = EvetHayir.Evet.ToName();
            txtYaziciAdi.EditValue = GeneralFunctions.DefaultYazici();
        }

        protected internal override IBaseEntity ReturnEntity()
        {
            var entity = new DokumParametreleri()
            {
                RaporBaslik = txtRaporBasligi.Text,
                BaslikEkle = txtBaslikEkle.Text.GetEnum<EvetHayir>(),
                RaporuKagidaSigdir = txtRaporuKagidaSigdir.Text.GetEnum<RaporuKagidaSıgdırmaTuru>(),
                YazdirmaYonu = txtYazdirmaYonu.Text.GetEnum<YazdirmaYonu>(),
                YatayCizgileriGoster = txtYatayCizgileriGoster.Text.GetEnum<EvetHayir>(),
                DikeyCizgileriGoster = txtDikeyCizgileriGoster.Text.GetEnum<EvetHayir>(),
                SutunBasliklariniGoster = txtSutunBasliklariniGoster.Text.GetEnum<EvetHayir>(),
                YaziciAdi = txtYaziciAdi.Text,
                YazdirilacakAdet = (int)txtYazdirilacakAdet.Value,
                DokumSekli = _dokumSekli
            };
            return entity;
        }

        protected override void Yazdir()
        {
            _dokumSekli = DokumSekli.TabloYazdir;
            Close();
        }

        protected override void BaskiOnIzleme()
        {
            _dokumSekli = DokumSekli.TabloBaskiOnIzleme;
            Close();
        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sender != txtBaslikEkle) return;
            txtRaporBasligi.Enabled = txtBaslikEkle.Text.GetEnum<EvetHayir>() == EvetHayir.Evet;
        }
    }
}