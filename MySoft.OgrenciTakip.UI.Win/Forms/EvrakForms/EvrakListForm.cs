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

namespace MySoft.OgrenciTakip.UI.Win.Forms.EvrakForms
{
    public partial class EvrakListForm : BaseListForm
    {
        #region Variable

        private readonly Expression<Func<Evrak, bool>> _filter;

        #endregion

        public EvrakListForm()
        {
            InitializeComponent();
            Bll = new EvrakBll();
            _filter = x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId;
        }

        public EvrakListForm(params object[] prm) : this()
        {
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Evrak;
            FormShow = new ShowEditForms<EvrakEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {

            var list = ((EvrakBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaj("Kart");

            //Tablo.GridControl.DataSource = ((EvrakBll)Bll).List(x=>x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId ==AnaForm.DonemId);
        }
    }
}