using MySoft.OgrenciTakip.Bll.General;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Common.Functions;
using MySoft.OgrenciTakip.UI.Win.Forms.BaseForms;
using MySoft.OgrenciTakip.UI.Win.Show;

namespace MySoft.OgrenciTakip.UI.Win.Forms.OzelKodForms
{
    public partial class OzelKodListForm : BaseListForm
    {
        #region Variable

        private readonly OzelKodTuru _ozelKodTuru;
        private readonly KartTuru _ozelKodKartTuru; 

        #endregion

        public OzelKodListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new OzelKodBll();

            _ozelKodTuru = (OzelKodTuru)prm[0];
            _ozelKodKartTuru = (KartTuru)prm[1];
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.OzelKod;
            Navigator = longNavigator.Navigator;
            Text = $"{Text} - ( {_ozelKodTuru.ToName()} )";
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((OzelKodBll)Bll).List(x => x.KodTuru == _ozelKodTuru && x.KartTuru == _ozelKodKartTuru);
        }

        protected override void showEditForm(long id)
        {
            var result = ShowEditForms<OzelKodEditForm>.ShowDialogEditForm(KartTuru.OzelKod, id, _ozelKodTuru, _ozelKodKartTuru);
            ShowEditFormDefault(result);
        }
    }
}