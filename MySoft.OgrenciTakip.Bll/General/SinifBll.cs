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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySoft.OgrenciTakip.Bll.General
{
    public class SinifBll : BaseGenelBll<Sinif>, IBaseCommonBll
    {
        public SinifBll() : base(KartTuru.Sinif) { }

        public SinifBll(Control ctrl ) : base(ctrl, KartTuru.Sinif) { }

        public override BaseEntity Single(Expression<Func<Sinif, bool>> filter)
        {
            return BaseSingle(filter, x => new SinifS
            {
                Id = x.Id,
                Kod = x.Kod,
                SinifAdi = x.SinifAdi,
                GrupId = x.GrupId,
                GrupAdi = x.Grup.GrupAdi,
                HedefOgrenciSayisi = x.HedefOgrenciSayisi,
                HedefCiro = x.HedefCiro,
                SubeId = x.SubeId,
                Aciklama = x.Aciklama,
                Durum = x.Durum
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Sinif, bool>> filter)
        {
            return BaseList(filter, x => new SinifL
            {
                Id = x.Id,
                Kod = x.Kod,
                GrupAdi = x.Grup.GrupAdi,
                SinifAdi = x.SinifAdi,
                HedefOgrenciSayisi = x.HedefOgrenciSayisi,
                HedefCiro = x.HedefCiro,
                Aciklama = x.Aciklama
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}
