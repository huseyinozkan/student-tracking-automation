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
    public class IndirimBll : BaseGenelBll<Indirim>, IBaseCommonBll
    {
        public IndirimBll() : base(KartTuru.Indirim) { }

        public IndirimBll(Control ctrl) : base(ctrl, KartTuru.Indirim) { }

        public override BaseEntity Single(Expression<Func<Indirim, bool>> filter)
        {
            return BaseSingle(filter, x => new IndirimS
            {
                Id = x.Id,
                Kod = x.Kod,
                IndirimAdi = x.IndirimAdi,
                IndirimTuruAdi = x.IndirimTuru.IndirimTuruAdi,
                IndirimTuruId = x.IndirimTuruId,
                DonemId = x.DonemId,
                SubeId = x.SubeId,
                Aciklama = x.Aciklama,
                Durum = x.Durum
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Indirim, bool>> filter)
        {
            return BaseList(filter, x => new IndirimL
            {
                Id = x.Id,
                Kod = x.Kod,
                IndirimAdi = x.IndirimAdi,
                IndirimTuruAdi = x.IndirimTuru.IndirimTuruAdi,
                Aciklama = x.Aciklama
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}
