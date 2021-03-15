using MySoft.OgrenciTakip.UI.Win.Forms.BaseForms;
using MySoft.OgrenciTakip.Bll.General;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.UI.Win.Show;
using MySoft.OgrenciTakip.UI.Win.Functions;
using MySoft.OgrenciTakip.Model.Entities;

namespace MySoft.OgrenciTakip.UI.Win.Forms.RehberForms
{
    public partial class RehberListForm : BaseListForm
    {
        public RehberListForm()
        {
            InitializeComponent();
            Bll = new RehberBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Rehber;
            FormShow = new ShowEditForms<RehberEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((RehberBll)Bll).List(FilterFunctions.Filter<Rehber>(AktifKartlariGoster));
        }
    }
}