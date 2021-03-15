using System.Windows.Forms;
using MySoft.OgrenciTakip.Bll.Base;
using MySoft.OgrenciTakip.Bll.Interfaces;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Model.Entities;

namespace MySoft.OgrenciTakip.Bll.General
{
    public class TesvikBll : BaseGenelBll<Tesvik>, IBaseGenelBll, IBaseCommonBll
    {
        public TesvikBll() : base(KartTuru.Tesvik) { }

        public TesvikBll(Control ctrl) : base(ctrl, KartTuru.Tesvik) { }
    }
}
