using DevExpress.XtraEditors;
using MySoft.OgrenciTakip.Bll.General;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Common.Functions;
using MySoft.OgrenciTakip.Model.Dto;
using MySoft.OgrenciTakip.Model.Entities;
using MySoft.OgrenciTakip.UI.Win.Forms.BaseForms;
using MySoft.OgrenciTakip.UI.Win.Functions;
using System;

namespace MySoft.OgrenciTakip.UI.Win.Forms.IletisimForms
{
    public partial class IletisimEditForm : BaseEditForm
    {
        public IletisimEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new IletisimBll(myDataLayoutControl);
            txtKanGrubu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KanGrubu>());
            BaseKartTuru = KartTuru.Iletisim;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new IletisimS() : ((IletisimBll)Bll).Single(FilterFunctions.Filter<Iletisim>(Id));
            NesneyiKontrollereBagla();
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IletisimBll)Bll).YeniKodVer();
            txtTcKimlikNo.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (IletisimS)OldEntity;

            txtKod.Text = entity.Kod;
            txtTcKimlikNo.Text = entity.TcKimlikNo;
            txtAdi.Text = entity.Adi;
            txtSoyadi.Text = entity.Soyadi;
            txtEvTel.Text = entity.EvTel;
            txtIsTel1.Text = entity.IsTel1;
            txtDahili1.Text = entity.Dahili1;
            txtIsTel2.Text = entity.IsTel2;
            txtDahili2.Text = entity.Dahili2;
            txtCepTel1.Text = entity.CepTel1;
            txtCepTel2.Text = entity.CepTel2;
            txtWeb.Text = entity.Web;
            txtEmail.Text = entity.Email;
            txtIbanNo.Text = entity.IbanNo;
            txtKartNo.Text = entity.KartNo;
            txtEvAdres.Text = entity.EvAdres;
            txtEvAdresIl.Id = entity.EvAdresIlId;
            txtEvAdresIl.Text = entity.EvAdresIlAdi;
            txtEvAdresIlce.Id = entity.EvAdresIlceId;
            txtEvAdresIlce.Text = entity.EvAdresIlceAdi;
            txtIsAdres.Text = entity.IsAdres;
            txtIsAdresIl.Id = entity.IsAdresIlId;
            txtIsAdresIl.Text = entity.IsAdresIlAdi;
            txtIsAdresIlce.Id = entity.IsAdresIlceId;
            txtIsAdresIlce.Text = entity.IsAdresIlceAdi;
            txtMeslek.Id = entity.MeslekId;
            txtMeslek.Text = entity.MeslekAdi;
            txtIsyeri.Id = entity.IsyeriId;
            txtIsyeri.Text = entity.IsyeriAdi;
            txtGorev.Id = entity.GorevId;
            txtGorev.Text = entity.GorevAdi;
            txtBabaAdi.Text = entity.BabaAdi;
            txtAnaAdi.Text = entity.AnaAdi;
            txtDogumYeri.Text = entity.DogumYeri;
            txtDogumTarihi.EditValue = entity.DogumTarihi;
            txtKanGrubu.SelectedItem = entity.KanGrubu.ToName();
            txtKimlikSeri.Text = entity.KimlikSeri;
            txtKimlikSıraNo.Text = entity.KimlikSiraNo;
            txtKimlikIl.Id = entity.KimlikIlId;
            txtKimlikIl.Text = entity.KimlikIlAdi;
            txtKimlikIlce.Id = entity.KimlikIlceId;
            txtKimlikIlce.Text = entity.KimlikIlceAdi;
            txtKimlikMahalleKoy.Text = entity.KimlikMahalleKoy;
            txtKimlikBireySıraNo.Text = entity.KimlikBireySiraNo;
            txtKimlikCiltNo.Text = entity.KimlikCiltNo;
            txtKimlikAileSıraNo.Text = entity.KimlikAileSiraNo;
            txtKimlikVerildigiYer.Text = entity.KimlikVerildigiYer;
            txtKimlikVerilisNedeni.Text = entity.KimlikVerilisNedeni;
            txtKimlikKayitNo.Text = entity.KimlikKayitNo;
            txtKimlikVerilisTarihi.EditValue = entity.KimlikVerilisTarihi;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Iletisim
            {
                Id = Id,
                Kod = txtKod.Text,
                TcKimlikNo = txtTcKimlikNo.Text,
                Adi = txtAdi.Text,
                Soyadi = txtSoyadi.Text,
                EvTel = txtEvTel.Text,
                IsTel1 = txtIsTel1.Text,
                IsTel2 = txtIsTel2.Text,
                Dahili1 = txtDahili1.Text,
                Dahili2 = txtDahili2.Text,
                CepTel1 = txtCepTel1.Text,
                CepTel2 = txtCepTel2.Text,
                Web = txtWeb.Text,
                Email = txtEmail.Text,
                IbanNo = txtIbanNo.Text,
                KartNo = txtKartNo.Text,
                EvAdres = txtEvAdres.Text,
                EvAdresIlId = txtEvAdresIl.Id,
                EvAdresIlceId = txtEvAdresIlce.Id,
                IsAdres = txtIsAdres.Text,
                IsAdresIlId = txtIsAdresIl.Id,
                IsAdresIlceId = txtIsAdresIlce.Id,
                MeslekId = txtMeslek.Id,
                IsyeriId = txtIsyeri.Id,
                GorevId = txtGorev.Id,
                BabaAdi = txtBabaAdi.Text,
                AnaAdi = txtAnaAdi.Text,
                DogumYeri = txtDogumYeri.Text,
                DogumTarihi = (DateTime?)txtDogumTarihi.EditValue,
                KanGrubu = txtKanGrubu.Text.GetEnum<KanGrubu>(),
                KimlikSeri = txtKimlikSeri.Text,
                KimlikSiraNo = txtKimlikSıraNo.Text,
                KimlikIlId = txtKimlikIl.Id,
                KimlikIlceId = txtKimlikIlce.Id,
                KimlikMahalleKoy =txtKimlikMahalleKoy.Text,
                KimlikBireySiraNo = txtKimlikBireySıraNo.Text,
                KimlikCiltNo = txtKimlikCiltNo.Text,
                KimlikAileSiraNo = txtKimlikAileSıraNo.Text,
                KimlikVerildigiYer = txtKimlikVerildigiYer.Text,
                KimlikVerilisNedeni = txtKimlikVerilisNedeni.Text,
                KimlikKayitNo = txtKimlikKayitNo.Text,
                KimlikVerilisTarihi = (DateTime?)txtKimlikVerilisTarihi.EditValue,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurum();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtEvAdresIl)
                    sec.Sec(txtEvAdresIl);
                else if (sender == txtEvAdresIlce)
                    sec.Sec(txtEvAdresIlce, txtEvAdresIl);
                else if (sender == txtIsAdresIl)
                    sec.Sec(txtIsAdresIl);
                else if (sender == txtIsAdresIlce)
                    sec.Sec(txtIsAdresIlce, txtIsAdresIl);
                else if (sender == txtMeslek)
                    sec.Sec(txtMeslek);
                else if (sender == txtIsyeri)
                    sec.Sec(txtIsyeri);
                else if (sender == txtGorev)
                    sec.Sec(txtGorev);
                else if (sender == txtKimlikIl)
                    sec.Sec(txtKimlikIl);
                else if (sender == txtKimlikIlce)
                    sec.Sec(txtKimlikIlce, txtKimlikIl);
                else if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.Iletisim);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Iletisim);
            }
        }

        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender != txtEvAdresIl && sender != txtIsAdresIl && sender != txtKimlikIl) return;

            if (sender == txtEvAdresIl)
                txtEvAdresIl.ControlEnabledChange(txtEvAdresIlce);
            else if (sender == txtIsAdresIl)
                txtIsAdresIl.ControlEnabledChange(txtIsAdresIlce);
            else if (sender == txtKimlikIl)
                txtKimlikIl.ControlEnabledChange(txtKimlikIlce);
        }


        // Bu Form Sube yada Dönem e göre sınırlandırılmadığı için insert ve update fonksiyonları override edilmedi. 
        // doğum tarihi ve veriliş tarihi boş geçilebildiği için allowNullİnput özelliği true yapıldı;
    }
}