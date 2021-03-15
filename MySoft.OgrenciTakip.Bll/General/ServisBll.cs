using MySoft.OgrenciTakip.Bll.Base;
using MySoft.OgrenciTakip.Bll.Interfaces;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace MySoft.OgrenciTakip.Bll.General
{
    public class ServisBll : BaseGenelBll<Servis>, IBaseCommonBll
    {
        public ServisBll() : base(KartTuru.Servis) { }

        public ServisBll(Control ctrl) : base(ctrl, KartTuru.Servis) { }
    }
}
