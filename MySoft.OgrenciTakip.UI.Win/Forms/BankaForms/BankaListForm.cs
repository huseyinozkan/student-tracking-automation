using DevExpress.XtraBars;
using MySoft.OgrenciTakip.Bll.General;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Model.Dto;
using MySoft.OgrenciTakip.Model.Entities;
using MySoft.OgrenciTakip.UI.Win.Forms.BankaSubeForms;
using MySoft.OgrenciTakip.UI.Win.Forms.BaseForms;
using MySoft.OgrenciTakip.UI.Win.Functions;
using MySoft.OgrenciTakip.UI.Win.Show;

namespace MySoft.OgrenciTakip.UI.Win.Forms.BankaForms
{
    public partial class BankaListForm : BaseListForm
    {
        public BankaListForm()
        {
            InitializeComponent();
            Bll = new BankaBll();
            btnBagliKartlar.Caption = "Şube Kartları";
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Banka;
            FormShow = new ShowEditForms<BankaEditForm>();
            Navigator = longNavigator.Navigator;

            if (IsMdiChild)
                ShowItems = new BarItem[] { btnBagliKartlar };
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((BankaBll)Bll).List(FilterFunctions.Filter<Banka>(AktifKartlariGoster));
        }
        
        protected override void BagliKartAc()
        {
            var entity = tablo.GetRow<BankaL>();
            if (entity == null) return;
            ShowListForms<BankaSubeListForm>.ShowListForm(KartTuru.BankaSube, entity.Id, entity.BankaAdi);
        }
    }
}