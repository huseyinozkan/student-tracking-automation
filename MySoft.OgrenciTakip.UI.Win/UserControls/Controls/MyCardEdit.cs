using MySoft.OgrenciTakip.UI.Win.UserControl.Controls;
using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using System.ComponentModel;

namespace MySoft.OgrenciTakip.UI.Win.UserControls.Controls
{
    public class MyCardEdit : MyTextEdit
    {
        [ToolboxItem(true)]
        public MyCardEdit()
        {
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.EditMask = @"\d?\d?\d?\d?-\d?\d?\d?\d?-\d?\d?\d?\d?-\d?\d?\d?\d?";
            Properties.Mask.AutoComplete = AutoCompleteType.None;
            StatusBarAciklama = "Kart No Giriniz.";
        }
    }
}
