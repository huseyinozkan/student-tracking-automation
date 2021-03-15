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
    public class AileBilgileriBll : BaseHareketBll<AileBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<AileBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<AileBilgileri, bool>> filter)
        {
            return List(filter, x => new AileBilgileriL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                AileBilgiId = x.AileBilgiId,
                BilgiAdi = x.AileBilgi.BilgiAdi,
                Aciklama = x.Aciklama

            }).ToList();
        }
    }
}
