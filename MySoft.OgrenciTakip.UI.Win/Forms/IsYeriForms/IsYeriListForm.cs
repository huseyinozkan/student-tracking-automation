using MySoft.OgrenciTakip.Bll.General;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Model.Entities;
using MySoft.OgrenciTakip.UI.Win.Forms.BaseForms;
using MySoft.OgrenciTakip.UI.Win.Functions;
using MySoft.OgrenciTakip.UI.Win.Show;

namespace MySoft.OgrenciTakip.UI.Win.Forms.IsYeriForms
{
    public partial class IsYeriListForm : BaseListForm
    {
        public IsYeriListForm()
        {
            InitializeComponent();
            Bll = new IsYeriBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.IsYeri;
            FormShow = new ShowEditForms<IsYeriEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IsYeriBll)Bll).List(FilterFunctions.Filter<IsYeri>(AktifKartlariGoster));
        }
    }
}