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
    public class PromosyonBilgileriBll : BaseHareketBll<PromosyonBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<PromosyonBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<PromosyonBilgileri, bool>> filter)
        {
            return List(filter, x => new PromosyonBilgileriL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                PromosyonId = x.PromosyonId,
                Kod = x.Promosyon.Kod,
                PromosyonAdi = x.Promosyon.PromosyonAdi
            }).ToList();
        }
    }
}
