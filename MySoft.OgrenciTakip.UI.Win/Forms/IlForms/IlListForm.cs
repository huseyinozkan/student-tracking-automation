using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySoft.OgrenciTakip.UI.Win.Forms.BaseForms;
using MySoft.OgrenciTakip.Bll.General;
using MySoft.OgrenciTakip.UI.Win.Show;
using MySoft.OgrenciTakip.UI.Win.Functions;
using MySoft.OgrenciTakip.Model.Entities;
using DevExpress.XtraBars;
using MySoft.OgrenciTakip.UI.Win.Forms.IlceForms;

namespace MySoft.OgrenciTakip.UI.Win.Forms.IlForms
{
    public partial class IlListForm : BaseListForm
    {
        public IlListForm()
        {
            InitializeComponent();
            Bll = new IlBll();
            btnBagliKartlar.Caption = "İlçe Kartları";
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.Il;
            FormShow = new ShowEditForms<IlEditForm>();
            Navigator = longNavigator1.Navigator;

            if (IsMdiChild)
                ShowItems = new BarItem[] { btnBagliKartlar };
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IlBll)Bll).List(FilterFunctions.Filter<Il>(AktifKartlariGoster));
        }
        protected override void BagliKartAc()
        {
            var entity = tablo.GetRow<Il>();
            if (entity == null) return;
            ShowListForms<IlceListForm>.ShowListForm(Common.Enums.KartTuru.Ilce, entity.Id, entity.IlAdi);
        }
    }
}