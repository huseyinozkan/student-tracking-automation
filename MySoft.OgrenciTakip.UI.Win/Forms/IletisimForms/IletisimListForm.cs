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

namespace MySoft.OgrenciTakip.UI.Win.Forms.IletisimForms
{
    public partial class IletisimListForm : BaseListForm
    {
        #region Variable

        private readonly Expression<Func<Iletisim, bool>> _filter;

        #endregion

        public IletisimListForm()
        {
            InitializeComponent();
            Bll = new IletisimBll();
            _filter = x => x.Durum == AktifKartlariGoster;
        }

        public IletisimListForm(params object[] prm) : this()
        {
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Iletisim;
            FormShow = new ShowEditForms<IletisimEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {

            var list = ((IletisimBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaj("Kart");

            //Tablo.GridControl.DataSource = ((IletisimBll)Bll).List(FilterFunctions.Filter<Iletisim>(AktifKartlariGoster));
        }
    }
}