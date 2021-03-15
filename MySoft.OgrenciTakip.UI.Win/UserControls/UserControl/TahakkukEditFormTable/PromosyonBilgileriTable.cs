using MySoft.OgrenciTakip.Bll.Functions;
using MySoft.OgrenciTakip.Bll.General;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Model.Dto;
using MySoft.OgrenciTakip.Model.Entities;
using MySoft.OgrenciTakip.UI.Win.Forms.PromosyonForms;
using MySoft.OgrenciTakip.UI.Win.Functions;
using MySoft.OgrenciTakip.UI.Win.Show;
using MySoft.OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System.Linq;

namespace MySoft.OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class PromosyonBilgileriTable : BaseTablo
    {
        public PromosyonBilgileriTable()
        {
            InitializeComponent();

            Bll = new PromosyonBilgileriBll();
            Tablo = tablo;
            EventLoad();
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((PromosyonBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<PromosyonBilgileriL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<PromosyonBilgileriL>().Where(x => !x.Delete).Select(x => x.PromosyonId).ToList();

            var entities = ShowListForms<PromosyonListForm>.ShowDialogListForm(KartTuru.Promosyon, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<Promosyon>();
            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new PromosyonBilgileriL
                {
                    TahakkukId = OwnerForm.Id,
                    PromosyonId = entity.Id,
                    Kod = entity.Kod,
                    PromosyonAdi = entity.PromosyonAdi,
                    Insert = true
                };

                source.Add(row);
            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colKod;

            ButonEnabledDurum(true);
        }
    }
}
