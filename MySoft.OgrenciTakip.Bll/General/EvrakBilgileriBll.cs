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
    public class EvrakBilgileriBll : BaseHareketBll<EvrakBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<EvrakBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<EvrakBilgileri, bool>> filter)
        {
            return List(filter, x => new EvrakBilgileriL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                Kod = x.Evrak.Kod,
                EvrakId = x.EvrakId,
                EvrakAdi = x.Evrak.EvrakAdi

            }).ToList();
        }
    }
}
