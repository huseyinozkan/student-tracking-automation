using System.Data;
using System.Linq;
using MySoft.OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using MySoft.OgrenciTakip.Bll.General;
using MySoft.OgrenciTakip.Model.Dto;
using MySoft.OgrenciTakip.UI.Win.Show;
using MySoft.OgrenciTakip.UI.Win.Forms.HizmetForms;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Bll.Functions;
using MySoft.OgrenciTakip.UI.Win.GenelForm;
using MySoft.OgrenciTakip.UI.Win.Functions;
using MySoft.OgrenciTakip.Common.Message;

namespace MySoft.OgrenciTakip.UI.Win.UserControls.UserControl.IndirimEditFormTable
{
    public partial class IndiriminUygulanacagiHizmetlerTable : BaseTablo
    {
        public IndiriminUygulanacagiHizmetlerTable()
        {
            InitializeComponent();

            Bll = new IndirimUygulanacagiHizmetBilgileriBll();
            Tablo = tablo;
            EventLoad();
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((IndirimUygulanacagiHizmetBilgileriBll)Bll).List(x => x.IndirimId == OwnerForm.Id).ToBindingList<IndiriminUygulanacagiHizmetBilgileriL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<IndiriminUygulanacagiHizmetBilgileriL>().Where(x => !x.Delete).Select(x => x.HizmetId).ToList();

            var entities = ShowListForms<HizmetListForm>.ShowDialogListForm(KartTuru.Hizmet, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<HizmetL>();
            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new IndiriminUygulanacagiHizmetBilgileriL
                {
                    IndirimId = OwnerForm.Id,
                    HizmetId = entity.Id,
                    HizmetAdi = entity.HizmetAdi,
                    IndirimTutari = 0,
                    IndirimOrani = 0,
                    SubeId = AnaForm.SubeId,
                    DonemId = AnaForm.DonemId,
                    Insert = true
                };

                source.Add(row);
            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colIndirimTutari;

            ButonEnabledDurum(true);
        }

        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;

            insUptNavigator.Navigator.Buttons.DoClick(insUptNavigator.Navigator.Buttons.EndEdit);
            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<IndiriminUygulanacagiHizmetBilgileriL>(i);
                if (entity.IndirimTutari == 0 || entity.IndirimOrani == 0) continue;
                tablo.Focus();
                tablo.FocusedRowHandle = i;
                Messages.HataMesaji("İndirim Tutarı Veya İndirim Oranı Alanlarından Sadece Birinin Değeri Sıfır'dan Büyük Olmalıdır.");
                return true;
            }
            return false;
        }
    }
}
