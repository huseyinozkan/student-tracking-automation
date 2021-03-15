using System.Windows.Forms;
using MySoft.OgrenciTakip.Bll.Base;
using MySoft.OgrenciTakip.Bll.Interfaces;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Model.Entities;

namespace MySoft.OgrenciTakip.Bll.General
{
    public class GorevBll : BaseGenelBll<Gorev>, IBaseGenelBll, IBaseCommonBll
    {
        public GorevBll() : base(KartTuru.Gorev) { }

        public GorevBll(Control ctrl) : base(ctrl, KartTuru.Gorev) { }
    }
}
