using DevExpress.XtraBars.Ribbon;
using MySoft.OgrenciTakip.Common.Enums;
using System;
using System.Windows.Forms;

namespace MySoft.OgrenciTakip.UI.Win.Show
{
    public class ShowRibbonForms<TForm> where TForm : RibbonForm
    {
        public static void ShowForm(bool dialog, params Object[] prm)
        {
            var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm);

            if (dialog)
                using (frm)
                    frm.ShowDialog();
            else
                frm.Show();
        }
        public static long ShowDialogForm(KartTuru kartTuru, params object[] prm)
        {
            // Yetki kontrolü

            var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm);

            using (frm)
            {
                frm.ShowDialog();
                return frm.DialogResult == DialogResult.OK ? (long)frm.Tag : 0;
            }
        }
    }
}