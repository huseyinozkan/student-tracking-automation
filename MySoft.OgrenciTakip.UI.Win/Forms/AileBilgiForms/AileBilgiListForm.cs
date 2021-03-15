using MySoft.OgrenciTakip.Bll.General;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Common.Message;
using MySoft.OgrenciTakip.Model.Entities;
using MySoft.OgrenciTakip.UI.Win.Forms.BaseForms;
using MySoft.OgrenciTakip.UI.Win.Functions;
using MySoft.OgrenciTakip.UI.Win.Show;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace MySoft.OgrenciTakip.UI.Win.Forms.AileBilgiForms
{
    public partial class AileBilgiListForm : BaseListForm
    {
        #region Variable

        private readonly Expression<Func<AileBilgi, bool>> _filter;

        #endregion

        public AileBilgiListForm()
        {
            InitializeComponent();
            Bll = new AileBilgiBll();
            _filter = x => x.Durum == AktifKartlariGoster;
        }

        public AileBilgiListForm(params object[] prm) : this()
        {
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.AileBilgi;
            FormShow = new ShowEditForms<AileBilgiEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {

            var list = ((AileBilgiBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaj("Kart");
        }
    }
}