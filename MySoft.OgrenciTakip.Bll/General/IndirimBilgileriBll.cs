using MySoft.OgrenciTakip.Bll.Base;
using MySoft.OgrenciTakip.Bll.Interfaces;
using MySoft.OgrenciTakip.Data.Contexts;
using MySoft.OgrenciTakip.Model.Dto;
using MySoft.OgrenciTakip.Model.Entities;
using MySoft.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MySoft.OgrenciTakip.Bll.General
{
    public class IndirimBilgileriBll : BaseHareketBll<IndirimBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<IndirimBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<IndirimBilgileri, bool>> filter)
        {
            return List(filter, x => new IndirimBilgileriL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                IndirimId = x.IndirimId,
                IndirimAdi = x.IptalEdildi ? x.Indirim.IndirimAdi + " - ( *** İptal Edildi *** )" : x.Indirim.IndirimAdi,
                HizmetId = x.HizmetId,
                HizmetAdi = x.Hizmet.HizmetAdi,
                IslemTarihi = x.IslemTarihi,
                BrutIndirim = x.BrutIndirim,
                KistDonemDusulenIndirim = x.KistDonemDusulenIndirim,
                NetIndirim = x.NetIndirim,
                IptalEdildi = x.IptalEdildi,
                IptalTarihi = x.IptalTarihi,
                OranliIndirim = x.OranliIndirim,
                ManuelGirilenTutar = x.ManuelGirilenTutar,
                HizmetHaraketId = x.HizmetHaraketId,
                IptalNedeniId = x.IptalNedeniId,
                IptalNedeniAdi = x.IptalNedeni.IptalNedeniAdi,
                IptalAciklama = x.IptalAciklama
            }).OrderByDescending(x => x.IptalEdildi).ThenBy(x => x.IptalTarihi).ThenBy(x => x.Id).ToList();
        }
    }
    
}
