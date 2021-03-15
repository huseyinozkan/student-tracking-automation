using MySoft.OgrenciTakip.Bll.General;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Model.Entities;
using MySoft.OgrenciTakip.UI.Win.Forms.BaseForms;
using MySoft.OgrenciTakip.UI.Win.Functions;
using MySoft.OgrenciTakip.UI.Win.Show;

namespace MySoft.OgrenciTakip.UI.Win.Forms.GorevForms
{
    public partial class GorevListForm : BaseListForm
    {
        public GorevListForm()
        {
            InitializeComponent();
            Bll = new GorevBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Gorev;
            FormShow = new ShowEditForms<GorevEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((GorevBll)Bll).List(FilterFunctions.Filter<Gorev>(AktifKartlariGoster));
        }
    }
}