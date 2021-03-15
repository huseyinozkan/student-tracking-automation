using MySoft.OgrenciTakip.Bll.General;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Model.Entities;
using MySoft.OgrenciTakip.UI.Win.Forms.BaseForms;
using MySoft.OgrenciTakip.UI.Win.Functions;
using MySoft.OgrenciTakip.UI.Win.Show;

namespace MySoft.OgrenciTakip.UI.Win.Forms.KontenjanForms
{
    public partial class KontenjanListForm : BaseListForm
    {
        public KontenjanListForm()
        {
            InitializeComponent();
            Bll = new KontenjanBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Kontenjan;
            FormShow = new ShowEditForms<KontenjanEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KontenjanBll)Bll).List(FilterFunctions.Filter<Kontenjan>(AktifKartlariGoster));
        }
    }
}