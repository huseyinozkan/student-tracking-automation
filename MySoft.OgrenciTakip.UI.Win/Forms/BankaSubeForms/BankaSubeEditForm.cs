using MySoft.OgrenciTakip.Bll.General;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Model.Entities;
using MySoft.OgrenciTakip.UI.Win.Forms.BaseForms;
using MySoft.OgrenciTakip.UI.Win.Functions;

namespace MySoft.OgrenciTakip.UI.Win.Forms.BankaSubeForms
{
    public partial class BankaSubeEditForm : BaseEditForm
    {
        private readonly long _bankaId;
        private readonly string _bankaAdi;

        public BankaSubeEditForm(params object[] prm)
        {
            InitializeComponent();

            _bankaId = (long)prm[0];
            _bankaAdi = prm[1].ToString();

            DataLayoutControl = myDataLayoutControl;
            Bll = new BankaSubeBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.BankaSube;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new BankaSube() : ((BankaSubeBll)Bll).Single(FilterFunctions.Filter<BankaSube>(Id));
            NesneyiKontrollereBagla();
            Text = Text + $" - ( {_bankaAdi} )";

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((BankaSubeBll)Bll).YeniKodVer(x => x.BankaId == _bankaId);
            txtSubeAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (BankaSube)OldEntity;

            txtKod.Text = entity.Kod;
            txtSubeAdi.Text = entity.SubeAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new BankaSube()
            {
                Id = Id,
                Kod = txtKod.Text,
                SubeAdi = txtSubeAdi.Text,
                BankaId = _bankaId,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurum();
        }

        protected override bool EntityInsert()
        {
            return ((BankaSubeBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.BankaId == _bankaId);
        }

        protected override bool EntityUpdate()
        {
            return ((BankaSubeBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.BankaId == _bankaId);
        }
    }
}