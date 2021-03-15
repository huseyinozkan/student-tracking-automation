using MySoft.OgrenciTakip.Bll.Base;
using MySoft.OgrenciTakip.Bll.Interfaces;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Model.Dto;
using MySoft.OgrenciTakip.Model.Entities;
using MySoft.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace MySoft.OgrenciTakip.Bll.General
{
    public class OgrenciBll : BaseGenelBll<Ogrenci>, IBaseGenelBll, IBaseCommonBll
    {
        public OgrenciBll() : base(KartTuru.Ogrenci) { }

        public OgrenciBll(Control ctrl) : base(ctrl, KartTuru.Ogrenci) { }

        public override BaseEntity Single(Expression<Func<Ogrenci, bool>> filter)
        {
            return BaseSingle(filter, x => new OgrenciS
            {
                Id = x.Id,
                Kod = x.Kod,
                Adi = x.Adi,
                Soyadi = x.Soyadi,
                AnaAdi = x.AnaAdi,
                BabaAdi = x.BabaAdi,
                DogumTarihi = x.DogumTarihi,
                DogumYeri = x.DogumYeri,
                KanGrubu = x.KanGrubu,
                Cinsiyet = x.Cinsiyet,
                Telefon = x.Telefon,
                Resim = x.Resim,
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
                TcKimlikNo = x.TcKimlikNo,
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Id = x.OzelKod2Id,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                OzelKod3Id = x.OzelKod3Id,
                OzelKod3Adi = x.OzelKod3.OzelKodAdi,
                OzelKod4Id = x.OzelKod4Id,
                OzelKod4Adi = x.OzelKod4.OzelKodAdi,
                OzelKod5Id = x.OzelKod5Id,
                OzelKod5Adi = x.OzelKod5.OzelKodAdi,
                Durum = x.Durum
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Ogrenci, bool>> filter)
        {
            return BaseList(filter, x => new OgrenciL
            {
                Id = x.Id,
                Kod = x.Kod,
                Adi = x.Adi,
                Soyadi = x.Soyadi,
                AnaAdi = x.AnaAdi,
                BabaAdi = x.BabaAdi,
                DogumTarihi = x.DogumTarihi,
                DogumYeri = x.DogumYeri,
                KanGrubu = x.KanGrubu,
                Cinsiyet = x.Cinsiyet,
                Telefon = x.Telefon,
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
                TcKimlikNo = x.TcKimlikNo,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                OzelKod3Adi = x.OzelKod3.OzelKodAdi,
                OzelKod4Adi = x.OzelKod4.OzelKodAdi,
                OzelKod5Adi = x.OzelKod5.OzelKodAdi
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}
