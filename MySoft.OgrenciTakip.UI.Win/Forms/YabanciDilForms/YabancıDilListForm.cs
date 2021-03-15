using MySoft.OgrenciTakip.Bll.General;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Model.Entities;
using MySoft.OgrenciTakip.UI.Win.Forms.BaseForms;
using MySoft.OgrenciTakip.UI.Win.Functions;
using MySoft.OgrenciTakip.UI.Win.Show;

namespace MySoft.OgrenciTakip.UI.Win.Forms.YabanciDilForms
{
    public partial class YabancıDilListForm : BaseListForm
    {
        public YabancıDilListForm()
        {
            InitializeComponent();
            Bll = new YabanciDilBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.YabanciDil;
            FormShow = new ShowEditForms<YabanciDilEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((YabanciDilBll)Bll).List(FilterFunctions.Filter<YabanciDil>(AktifKartlariGoster));
        }
    }
}