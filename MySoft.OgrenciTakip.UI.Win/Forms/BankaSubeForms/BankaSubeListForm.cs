using MySoft.OgrenciTakip.Bll.General;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.UI.Win.Forms.BaseForms;
using MySoft.OgrenciTakip.UI.Win.Show;

namespace MySoft.OgrenciTakip.UI.Win.Forms.BankaSubeForms
{
    public partial class BankaSubeListForm : BaseListForm
    {
        private readonly long _bankaId;
        private readonly string _bankaAdi;

        public BankaSubeListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new BankaSubeBll();

            _bankaId = (long)prm[0];
            _bankaAdi = prm[1].ToString();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.BankaSube;
            Navigator = longNavigator.Navigator;
            Text = Text + $" - ( {_bankaAdi} )";
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((BankaSubeBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.BankaId == _bankaId);
        }

        protected override void showEditForm(long id)
        {
            var result = ShowEditForms<BankaSubeEditForm>.ShowDialogEditForm(KartTuru.BankaSube, id, _bankaId, _bankaAdi);
            ShowEditFormDefault(result);
        }
    }
}