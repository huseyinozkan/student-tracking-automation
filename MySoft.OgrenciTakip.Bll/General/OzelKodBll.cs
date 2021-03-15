using System.Windows.Forms;
using MySoft.OgrenciTakip.Bll.Base;
using MySoft.OgrenciTakip.Bll.Interfaces;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Model.Entities;

namespace MySoft.OgrenciTakip.Bll.General
{
    public class OzelKodBll : BaseGenelBll<OzelKod>, IBaseCommonBll
    {
        public OzelKodBll() : base(KartTuru.OzelKod) { }

        public OzelKodBll(Control ctrl) : base(ctrl, KartTuru.OzelKod) { }
    }
}
