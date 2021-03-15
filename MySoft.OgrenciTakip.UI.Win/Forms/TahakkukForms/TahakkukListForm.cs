using DevExpress.XtraBars;
using MySoft.OgrenciTakip.Bll.General;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Common.Message;
using MySoft.OgrenciTakip.Model.Entities;
using MySoft.OgrenciTakip.UI.Win.Forms.BaseForms;
using MySoft.OgrenciTakip.UI.Win.GenelForm;
using MySoft.OgrenciTakip.UI.Win.Show;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace MySoft.OgrenciTakip.UI.Win.Forms.TahakkukForms
{
    public partial class TahakkukListForm : BaseListForm
    {
        #region Variables

        private readonly Expression<Func<Tahakkuk, bool>> _filter; 
        
        #endregion

        public TahakkukListForm()
        {
            InitializeComponent();
            Bll = new TahakkukBll();
            HideItems = new BarItem[] { btnYeni };
            _filter = x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId;
        }

        public TahakkukListForm(params object[] prm) : this()
        {
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Tahakkuk;
            FormShow = new ShowEditForms<TahakkukEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            var list = ((TahakkukBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaj("Kart");
        }
    }
}