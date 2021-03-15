using MySoft.OgrenciTakip.Bll.General;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Model.Entities;
using MySoft.OgrenciTakip.UI.Win.Forms.BaseForms;
using MySoft.OgrenciTakip.UI.Win.Functions;
using MySoft.OgrenciTakip.UI.Win.Show;

namespace MySoft.OgrenciTakip.UI.Win.Forms.SinifGrupForms
{
    public partial class SinifGrupListForm : BaseListForm
    {
        public SinifGrupListForm()
        {
            InitializeComponent();
            Bll = new SinifGrupBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.SinifGrup;
            FormShow = new ShowEditForms<SinifGrupEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((SinifGrupBll)Bll).List(FilterFunctions.Filter<SinifGrup>(AktifKartlariGoster));
        }
    }
}