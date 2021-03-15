using MySoft.OgrenciTakip.Bll.General;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Model.Entities;
using MySoft.OgrenciTakip.UI.Win.Forms.BaseForms;
using MySoft.OgrenciTakip.UI.Win.Functions;

namespace MySoft.OgrenciTakip.UI.Win.Forms.IsYeriForms
{
    public partial class IsYeriEditForm : BaseEditForm
    {
        public IsYeriEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new IsYeriBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.IsYeri;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new IsYeri() : ((IsYeriBll)Bll).Single(FilterFunctions.Filter<IsYeri>(Id));
            NesneyiKontrollereBagla();
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IsYeriBll)Bll).YeniKodVer();
            txtIsYeriAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (IsYeri)OldEntity;

            txtKod.Text = entity.Kod;
            txtIsYeriAdi.Text = entity.IsYeriAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new IsYeri
            {
                Id = Id,
                Kod = txtKod.Text,
                IsYeriAdi = txtIsYeriAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurum();
        }
    }
}