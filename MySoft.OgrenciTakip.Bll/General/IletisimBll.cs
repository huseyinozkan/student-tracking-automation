using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using MySoft.OgrenciTakip.Bll.Base;
using MySoft.OgrenciTakip.Bll.Interfaces;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Model.Dto;
using MySoft.OgrenciTakip.Model.Entities;
using MySoft.OgrenciTakip.Model.Entities.Base;

namespace MySoft.OgrenciTakip.Bll.General
{
    public class IletisimBll : BaseGenelBll<Iletisim>, IBaseGenelBll, IBaseCommonBll
    {
        public IletisimBll() : base(KartTuru.Iletisim) { }

        public IletisimBll(Control ctrl) : base(ctrl, KartTuru.Iletisim) { }

        public override BaseEntity Single(Expression<Func<Iletisim, bool>> filter)
        {
            return BaseSingle(filter, x => new IletisimS
            {
                Id = x.Id,
                Kod = x.Kod,
                Adi = x.Adi,
                Soyadi = x.Soyadi,
                AnaAdi = x.AnaAdi,
                BabaAdi = x.BabaAdi,
                CepTel1 = x.CepTel1,
                CepTel2 = x.CepTel2,
                Dahili1 = x.Dahili1,
                Dahili2 = x.Dahili2,
                DogumTarihi = x.DogumTarihi,
                DogumYeri = x.DogumYeri,
                Email = x.Email,
                EvAdres = x.EvAdres,
                EvAdresIlAdi = x.EvAdresIl.IlAdi,
                EvAdresIlceAdi = x.EvAdresIlce.IlceAdi,
                EvAdresIlceId = x.EvAdresIlceId,
                EvAdresIlId = x.EvAdresIlId,
                EvTel = x.EvTel,
                GorevAdi = x.Gorev.GorevAdi,
                GorevId = x.GorevId,
                IsAdresIlAdi = x.IsAdresIl.IlAdi,
                IsAdresIlceAdi = x.IsAdresIlce.IlceAdi,
                IsAdresIlceId = x.IsAdresIlceId,
                IsAdresIlId = x.IsAdresIlId,
                IsTel1 = x.IsTel1,
                IsTel2 = x.IsTel2,
                IsAdres = x.IsAdres,
                IsyeriAdi = x.Isyeri.IsYeriAdi,
                IsyeriId = x.IsyeriId,
                KanGrubu = x.KanGrubu,
                KartNo = x.KartNo,
                KimlikAileSiraNo = x.KimlikAileSiraNo,
                KimlikBireySiraNo = x.KimlikBireySiraNo,
                KimlikCiltNo = x.KimlikCiltNo,
                KimlikIlAdi = x.KimlikIl.IlAdi,
                KimlikIlceAdi = x.KimlikIlce.IlceAdi,
                KimlikIlceId = x.KimlikIlceId,
                KimlikIlId = x.KimlikIlId,
                KimlikKayitNo = x.KimlikKayitNo,
                KimlikMahalleKoy = x.KimlikMahalleKoy,
                KimlikSeri = x.KimlikSeri,
                KimlikSiraNo = x.KimlikSiraNo,
                KimlikVerildigiYer = x.KimlikVerildigiYer,
                KimlikVerilisNedeni = x.KimlikVerilisNedeni,
                KimlikVerilisTarihi = x.KimlikVerilisTarihi,
                MeslekAdi = x.Meslek.MeslekAdi,
                MeslekId = x.MeslekId,
                TcKimlikNo = x.TcKimlikNo,
                Web = x.Web,
                IbanNo = x.IbanNo,
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Id = x.OzelKod2Id,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama,
                Durum = x.Durum
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Iletisim, bool>> filter)
        {
            return BaseList(filter, x => new IletisimL
            {
                Id = x.Id,
                Kod = x.Kod,
                Adi = x.Adi,
                Soyadi = x.Soyadi,
                AnaAdi = x.AnaAdi,
                BabaAdi = x.BabaAdi,
                CepTel1 = x.CepTel1,
                CepTel2 = x.CepTel2,
                Dahili1 = x.Dahili1,
                Dahili2 = x.Dahili2,
                DogumTarihi = x.DogumTarihi,
                DogumYeri = x.DogumYeri,
                Email = x.Email,
                EvAdres = x.EvAdres,
                EvAdresIlAdi = x.EvAdresIl.IlAdi,
                EvAdresIlceAdi = x.EvAdresIlce.IlceAdi,
                EvTel = x.EvTel,
                GorevAdi = x.Gorev.GorevAdi,
                IsAdresIlAdi = x.IsAdresIl.IlAdi,
                IsAdresIlceAdi = x.IsAdresIlce.IlceAdi,
                IsTel1 = x.IsTel1,
                IsTel2 = x.IsTel2,
                IsAdres = x.IsAdres,
                IsyeriAdi = x.Isyeri.IsYeriAdi,
                KanGrubu = x.KanGrubu,
                KartNo = x.KartNo,
                KimlikAileSiraNo = x.KimlikAileSiraNo,
                KimlikBireySiraNo = x.KimlikBireySiraNo,
                KimlikCiltNo = x.KimlikCiltNo,
                KimlikIlAdi = x.KimlikIl.IlAdi,
                KimlikIlceAdi = x.KimlikIlce.IlceAdi,
                KimlikKayitNo = x.KimlikKayitNo,
                KimlikMahalleKoy = x.KimlikMahalleKoy,
                KimlikSeri = x.KimlikSeri,
                KimlikSiraNo = x.KimlikSiraNo,
                KimlikVerildigiYer = x.KimlikVerildigiYer,
                KimlikVerilisNedeni = x.KimlikVerilisNedeni,
                KimlikVerilisTarihi = x.KimlikVerilisTarihi,
                MeslekAdi = x.Meslek.MeslekAdi,
                TcKimlikNo = x.TcKimlikNo,
                Web = x.Web,
                IbanNo = x.IbanNo,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}