using System.Windows.Forms;
using MySoft.OgrenciTakip.Bll.Base;
using MySoft.OgrenciTakip.Bll.Interfaces;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Model.Entities;

namespace MySoft.OgrenciTakip.Bll.General
{
    public class SinifGrupBll : BaseGenelBll<SinifGrup>, IBaseGenelBll, IBaseCommonBll
    {
        public SinifGrupBll() : base(KartTuru.SinifGrup) { }

        public SinifGrupBll(Control ctrl) : base(ctrl, KartTuru.SinifGrup) { }
    }
}
