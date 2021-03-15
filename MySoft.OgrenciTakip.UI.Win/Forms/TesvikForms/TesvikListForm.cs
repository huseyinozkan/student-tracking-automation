using MySoft.OgrenciTakip.UI.Win.Forms.BaseForms;
using MySoft.OgrenciTakip.Bll.General;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.UI.Win.Show;
using MySoft.OgrenciTakip.UI.Win.Functions;
using MySoft.OgrenciTakip.Model.Entities;

namespace MySoft.OgrenciTakip.UI.Win.Forms.TesvikForms
{
    public partial class TesvikListForm : BaseListForm
    {
        public TesvikListForm()
        {
            InitializeComponent();
            Bll = new TesvikBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Tesvik;
            FormShow = new ShowEditForms<TesvikEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((TesvikBll)Bll).List(FilterFunctions.Filter<Tesvik>(AktifKartlariGoster));
        }
    }
}