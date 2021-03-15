using MySoft.OgrenciTakip.UI.Win.Forms.BaseForms;
using MySoft.OgrenciTakip.Bll.General;
using MySoft.OgrenciTakip.UI.Win.Show;
using DevExpress.XtraGrid;
using MySoft.OgrenciTakip.Common.Enums;

namespace MySoft.OgrenciTakip.UI.Win.Forms.FiltreForms
{
    public partial class FiltreListForm : BaseListForm
    {
        private readonly KartTuru _filtreKartTuru;
        private readonly GridControl _filtreGrid;

        public FiltreListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new FiltreBll();

            _filtreKartTuru = (KartTuru)prm[0];
            _filtreGrid = (GridControl)prm[1];

            HideItems = new DevExpress.XtraBars.BarItem[] { btnFiltrele, btnKolonlar, btnYazdir, btnGonder, barFiltrele, barFiltreleAciklama, barKolonlar, barKolonlarAciklama, barYazdir, barYazdirAciklama, barGonder, barGonderAciklama };
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.Filtre;
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((FiltreBll)Bll).List(x=>x.KartTuru == _filtreKartTuru);
        }

        protected override void showEditForm(long id)
        {
            var result = ShowEditForms<FiltreEditForm>.ShowDialogEditForm(Common.Enums.KartTuru.Filtre, id, _filtreKartTuru, _filtreGrid);
            ShowEditFormDefault(result);
        }
    }
}