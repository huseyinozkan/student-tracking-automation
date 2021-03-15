using DevExpress.XtraEditors;
using MySoft.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;

namespace MySoft.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyFilterControl: FilterControl, IStatusBarAciklama
    {
        public MyFilterControl()
        {
            ShowGroupCommandsIcon = true;
        }

        public string StatusBarAciklama { get; set; } = "Filtre Metni Giriniz.";
    }
}
