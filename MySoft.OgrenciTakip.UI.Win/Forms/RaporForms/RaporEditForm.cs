﻿using MySoft.OgrenciTakip.Bll.General;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Model.Entities;
using MySoft.OgrenciTakip.UI.Win.Forms.BaseForms;
using MySoft.OgrenciTakip.UI.Win.Functions;

namespace MySoft.OgrenciTakip.UI.Win.Forms.RaporForms
{
    public partial class RaporEditForm : BaseEditForm
    {
        private readonly KartTuru _raporTuru;
        private readonly RaporBolumTuru _raporBolumTuru;
        private readonly byte[] _dosya;

        public RaporEditForm(params object[] prm)
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new RaporBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Rapor;
            EventsLoad();

            _raporTuru = (KartTuru)prm[0];
            _raporBolumTuru = (RaporBolumTuru)prm[1];
            _dosya = (byte[])prm[2];
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Rapor() : ((RaporBll)Bll).Single(FilterFunctions.Filter<Rapor>(Id));
            NesneyiKontrollereBagla();
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((RaporBll)Bll).YeniKodVer(x=>x.RaporBolumTuru == _raporBolumTuru);
            txtRaporAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Rapor)OldEntity;

            txtKod.Text = entity.Kod;
            txtRaporAdi.Text = entity.RaporAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Rapor
            {
                Id = Id,
                Kod = txtKod.Text,
                RaporAdi = txtRaporAdi.Text,
                RaporTuru = _raporTuru,
                RaporBolumTuru = _raporBolumTuru,
                Dosya = _dosya,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurum();
        }

        protected override bool EntityInsert()
        {
            return ((RaporBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.RaporBolumTuru == _raporBolumTuru);
        }

        protected override bool EntityUpdate()
        {
            return ((RaporBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.RaporBolumTuru == _raporBolumTuru);
        }
    }
}