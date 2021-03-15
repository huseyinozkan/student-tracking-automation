using MySoft.OgrenciTakip.Bll.Base;
using MySoft.OgrenciTakip.Bll.Interfaces;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace MySoft.OgrenciTakip.Bll.General
{
    public class PromosyonBll : BaseGenelBll<Promosyon>, IBaseCommonBll
    {
        public PromosyonBll() : base(KartTuru.Promosyon) { }

        public PromosyonBll(Control ctrl) : base(ctrl, KartTuru.Promosyon) { }
    }
}
