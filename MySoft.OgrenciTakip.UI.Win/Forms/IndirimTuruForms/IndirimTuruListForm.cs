using MySoft.OgrenciTakip.Bll.General;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Model.Entities;
using MySoft.OgrenciTakip.UI.Win.Forms.BaseForms;
using MySoft.OgrenciTakip.UI.Win.Functions;
using MySoft.OgrenciTakip.UI.Win.Show;

namespace MySoft.OgrenciTakip.UI.Win.Forms.IndirimTuruForms
{
    public partial class IndirimTuruListForm : BaseListForm
    {
        public IndirimTuruListForm()
        {
            InitializeComponent();
            Bll = new IndirimTuruBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.IndirimTuru;
            FormShow = new ShowEditForms<IndirimTuruEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IndirimTuruBll)Bll).List(FilterFunctions.Filter<IndirimTuru>(AktifKartlariGoster));
        }
    }
}