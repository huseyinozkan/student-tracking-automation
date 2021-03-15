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
    public class IndirimTuruBll : BaseGenelBll<IndirimTuru>, IBaseGenelBll, IBaseCommonBll
    {
        public IndirimTuruBll() : base(KartTuru.IndirimTuru) { }

        public IndirimTuruBll(Control ctrl) : base(ctrl, KartTuru.IndirimTuru) { }
    }
}
