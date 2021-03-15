using MySoft.OgrenciTakip.Bll.General;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Model.Entities;
using MySoft.OgrenciTakip.UI.Win.Forms.BaseForms;
using MySoft.OgrenciTakip.UI.Win.Functions;
using MySoft.OgrenciTakip.UI.Win.Show;

namespace MySoft.OgrenciTakip.UI.Win.Forms.OdemeTuruForms
{
    public partial class OdemeTuruListForm : BaseListForm
    {
        public OdemeTuruListForm()
        {
            InitializeComponent();
            Bll = new OdemeTuruBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.OdemeTuru;
            FormShow = new ShowEditForms<OdemeTuruEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((OdemeTuruBll)Bll).List(FilterFunctions.Filter<OdemeTuru>(AktifKartlariGoster));
        }
    }
}