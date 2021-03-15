using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MySoft.OgrenciTakip.Bll.Base;
using MySoft.OgrenciTakip.Bll.Interfaces;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Data.Contexts;
using MySoft.OgrenciTakip.Model.Dto;
using MySoft.OgrenciTakip.Model.Entities;
using MySoft.OgrenciTakip.Model.Entities.Base;

namespace MySoft.OgrenciTakip.Bll.General
{
    public class KardesBilgileriBll : BaseHareketBll<KardesBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<KardesBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<KardesBilgileri, bool>> filter)
        {
            return List(filter, x => new KardesBilgileriL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                KardesTahakkukId = x.KardesTahakkukId,
                Adi = x.KardesTahakkuk.Ogrenci.Adi,
                Soyadi = x.KardesTahakkuk.Ogrenci.Soyadi,
                SinifAdi = x.KardesTahakkuk.Sinif.SinifAdi,
                KayitSekli = x.KardesTahakkuk.KayitSekli,
                KayitDurumu = x.KardesTahakkuk.KayitDurumu,
                IptalDurumu = x.KardesTahakkuk.Durum?IptalDurumu.DevamEdiyor : IptalDurumu.IptalEdildi,
                SubeId = x.KardesTahakkuk.SubeId,
                SubeAdi = x.KardesTahakkuk.Sube.SubeAdi

            }).ToList();
        }
    }
}