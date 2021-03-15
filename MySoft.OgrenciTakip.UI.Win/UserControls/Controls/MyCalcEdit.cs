using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.Utils;
using MySoft.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;

namespace MySoft.OgrenciTakip.UI.Win.UserControl.Controls
{
    [ToolboxItem(true)]
    public class MyCalcEdit:CalcEdit, IStatusBarKisaYol
    {
        public MyCalcEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.DisplayFormat.FormatType = FormatType.Numeric;
            Properties.DisplayFormat.FormatString = "n2";
            Properties.EditMask = "n2";
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarKisaYol { get; set; } = "F4 :";
        public string StatusBarKisaYolAciklama { get; set; } = "Hesap Makinesi";
        public string StatusBarAciklama { get; set; }
    }
}
