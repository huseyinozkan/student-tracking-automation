using DevExpress.XtraEditors;
using MySoft.OgrenciTakip.Bll.General;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Model.Dto;
using MySoft.OgrenciTakip.Model.Entities;
using MySoft.OgrenciTakip.UI.Win.Forms.BaseForms;
using MySoft.OgrenciTakip.UI.Win.Functions;
using MySoft.OgrenciTakip.UI.Win.GenelForm;
using System;

namespace MySoft.OgrenciTakip.UI.Win.Forms.SinifForms
{
    public partial class SinifEditForm : BaseEditForm
    {
        public SinifEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new SinifBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Sinif;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new SinifS() : ((SinifBll)Bll).Single(FilterFunctions.Filter<Sinif>(Id));
            NesneyiKontrollereBagla();
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((SinifBll)Bll).YeniKodVer(x=>x.SubeId == AnaForm.SubeId);
            txtSinifAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (SinifS)OldEntity;

            txtKod.Text = entity.Kod;
            txtSinifAdi.Text = entity.SinifAdi;
            txtGrup.Id = entity.GrupId;
            txtGrup.Text = entity.GrupAdi;
            txtHedefOgrenciSayisi.Value = entity.HedefOgrenciSayisi;
            txtHedefCiro.Value = entity.HedefCiro;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Sinif()
            {
                Id = Id,
                Kod = txtKod.Text,
                SinifAdi = txtSinifAdi.Text,
                GrupId = Convert.ToInt64(txtGrup.Id),
                HedefOgrenciSayisi = (int)txtHedefOgrenciSayisi.Value,
                HedefCiro = txtHedefCiro.Value,
                Aciklama = txtAciklama.Text,
                SubeId = AnaForm.SubeId,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurum();
        }

        protected override bool EntityInsert()
        {
            return ((SinifBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId);
        }

        protected override bool EntityUpdate()
        {
            return ((SinifBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId);
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtGrup)
                    sec.Sec(txtGrup);
            }
        }
    }
}