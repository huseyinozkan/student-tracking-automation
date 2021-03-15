using DevExpress.XtraBars;
using MySoft.OgrenciTakip.Bll.Functions;
using MySoft.OgrenciTakip.Bll.General;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Model.Dto;
using MySoft.OgrenciTakip.Model.Entities;
using MySoft.OgrenciTakip.UI.Win.Forms.BaseForms;
using MySoft.OgrenciTakip.UI.Win.Forms.TahakkukForms;
using MySoft.OgrenciTakip.UI.Win.Functions;
using MySoft.OgrenciTakip.UI.Win.GenelForm;
using MySoft.OgrenciTakip.UI.Win.Show;

namespace MySoft.OgrenciTakip.UI.Win.Forms.OgrenciForms
{
    public partial class OgrenciListForm : BaseListForm
    {
        public OgrenciListForm()
        {
            InitializeComponent();
            Bll = new OgrenciBll();
            ShowItems = new BarItem[] { btnTahakkukYap };
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Ogrenci;
            FormShow = new ShowEditForms<OgrenciEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((OgrenciBll)Bll).List(FilterFunctions.Filter<Ogrenci>(AktifKartlariGoster));
        }
        protected override void TahakkukYap()
        {
            var entity = tablo.GetRow<OgrenciL>().EntityConvert<Ogrenci>();
            using (var Bll = new TahakkukBll())
            {
                var tahakkuk = Bll.SingleSummary(x => x.OgrenciId == entity.Id && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);

                if (tahakkuk != null)
                    ShowEditForms<TahakkukEditForm>.ShowDialogEditForm(KartTuru.Tahakkuk, tahakkuk.Id, null);
                else
                    ShowEditForms<TahakkukEditForm>.ShowDialogEditForm(KartTuru.Tahakkuk, -1, entity);
            }
        }
    }
}