using MySoft.OgrenciTakip.Bll.Base;
using MySoft.OgrenciTakip.Bll.Interfaces;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace MySoft.OgrenciTakip.Bll.General
{
    public class OdemeTuruBll : BaseGenelBll<OdemeTuru>, IBaseGenelBll, IBaseCommonBll
    {
        public OdemeTuruBll() : base(KartTuru.OdemeTuru) { }

        public OdemeTuruBll(Control ctrl) : base(ctrl, KartTuru.OdemeTuru) { }
    }
}
