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
using MySoft.OgrenciTakip.UI.Win.Functions;
using MySoft.OgrenciTakip.Model.Entities;
using MySoft.OgrenciTakip.UI.Win.Show;

namespace MySoft.OgrenciTakip.UI.Win.Forms.IlceForms
{
    public partial class IlceListForm : BaseListForm
    {
        private readonly long _ilId;
        private readonly string _ilAdi;

        public IlceListForm(params object[] prm)
        {
            InitializeComponent();

            Bll = new IlceBll();

            _ilId = (long)prm[0];
            _ilAdi = prm[1].ToString();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.Ilce;
            //FormShow = new ShowEditForms<IlceListForm>();
            Navigator = longNavigator1.Navigator;
            Text = Text + $" - ( {_ilAdi} )";
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IlceBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.IlId == _ilId);
        }

        protected override void showEditForm(long id)
        {
            var result = ShowEditForms<IlceEditForm>.ShowDialogEditForm(Common.Enums.KartTuru.Ilce, id, _ilId, _ilAdi);
            ShowEditFormDefault(result);
        }
    }
}