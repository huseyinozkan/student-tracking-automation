﻿using DevExpress.XtraEditors;
using MySoft.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace MySoft.OgrenciTakip.UI.Win.UserControl.Controls
{
    [ToolboxItem(true)]
    public class MyTextEdit:TextEdit, IStatusBarAciklama
    {
        public MyTextEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.MaxLength = 50;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; }
    }
}
