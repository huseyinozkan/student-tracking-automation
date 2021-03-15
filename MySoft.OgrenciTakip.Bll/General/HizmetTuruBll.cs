using System.Windows.Forms;
using MySoft.OgrenciTakip.Bll.Base;
using MySoft.OgrenciTakip.Bll.Interfaces;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Model.Entities;

namespace MySoft.OgrenciTakip.Bll.General
{
    public class HizmetTuruBll : BaseGenelBll<HizmetTuru>, IBaseGenelBll, IBaseCommonBll
    {
        public HizmetTuruBll() : base(KartTuru.HizmetTuru) { }

        public HizmetTuruBll(Control ctrl) : base(ctrl, KartTuru.HizmetTuru) { }
    }
}
