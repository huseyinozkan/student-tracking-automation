using MySoft.OgrenciTakip.Bll.Base;
using MySoft.OgrenciTakip.Bll.Interfaces;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySoft.OgrenciTakip.Bll.General
{
    public class IsYeriBll : BaseGenelBll<IsYeri>, IBaseGenelBll, IBaseCommonBll
    {
        public IsYeriBll() : base(KartTuru.IsYeri) { }

        public IsYeriBll(Control ctrl) : base(ctrl, KartTuru.IsYeri) { }
    }
}
