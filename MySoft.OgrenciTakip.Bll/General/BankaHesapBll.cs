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
    public class BankaHesapBll : BaseGenelBll<BankaHesap>, IBaseCommonBll
    {
        public BankaHesapBll() : base(KartTuru.BankaHesap) { }

        public BankaHesapBll(Control ctrl) : base(ctrl, KartTuru.BankaHesap) { }

        public override BaseEntity Single(Expression<Func<BankaHesap, bool>> filter)
        {
            return BaseSingle(filter, x => new BankaHesapS
            {
                Id = x.Id,
                Kod = x.Kod,
                BankaId = x.BankaId,
                BankaAdi = x.Banka.BankaAdi,
                BankaSubeId =x.BankaSubeId,
                BankaSubeAdi = x.BankaSube.SubeAdi,
                BlokeGunSayisi = x.BlokeGunSayisi,
                HesapAcilisTarihi = x.HesapAcilisTarihi,
                HesapAdi = x.HesapAdi,
                HesapNo = x.HesapNo,
                HesapTuru = x.HesapTuru,
                IbanNo = x.IbanNo,
                IsyeriNo = x.IsyeriNo,
                TerminalNo = x.TerminalNo,
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Id = x.OzelKod2Id,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama,
                SubeId = x.SubeId,
                Durum = x.Durum
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<BankaHesap, bool>> filter)
        {
            return BaseList(filter, x => new BankaHesapL
            {
                Id = x.Id,
                Kod = x.Kod,
                BankaAdi = x.Banka.BankaAdi,
                BankaSubeAdi = x.BankaSube.SubeAdi,
                BlokeGunSayisi = x.BlokeGunSayisi,
                HesapAcilisTarihi = x.HesapAcilisTarihi,
                HesapAdi = x.HesapAdi,
                HesapNo = x.HesapNo,
                HesapTuru = x.HesapTuru,
                IbanNo = x.IbanNo,
                IsyeriNo = x.IsyeriNo,
                TerminalNo = x.TerminalNo,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}
