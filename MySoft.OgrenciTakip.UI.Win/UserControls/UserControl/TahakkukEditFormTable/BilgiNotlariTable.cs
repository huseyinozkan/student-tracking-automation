using MySoft.OgrenciTakip.Bll.General;
using MySoft.OgrenciTakip.Common.Message;
using MySoft.OgrenciTakip.Model.Dto;
using MySoft.OgrenciTakip.UI.Win.Functions;
using MySoft.OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System;
using System.Linq;

namespace MySoft.OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class BilgiNotlariTable : BaseTablo
    {
        public BilgiNotlariTable()
        {
            InitializeComponent();

            Bll = new BilgiNotlariBll();
            Tablo = tablo;
            EventLoad();
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((BilgiNotlariBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<BilgiNotlariL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;

            var row = new BilgiNotlariL
            {
                TahakkukId = OwnerForm.Id,
                Tarih = DateTime.Now,
                Insert = true
            };

            source.Add(row);

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colBilgiNotu;

            ButonEnabledDurum(true);
        }

        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            insUptNavigator.Navigator.Buttons.DoClick(insUptNavigator.Navigator.Buttons.EndEdit);
            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<BilgiNotlariL>(i);
                if (string.IsNullOrEmpty(entity.BilgiNotu))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colBilgiNotu;
                    tablo.SetColumnError(colBilgiNotu, "Bilgi Notu Alanına Geçerli Bir Değer Giriniz.");
                }

                if (!tablo.HasColumnErrors) continue;

                Messages.TabloEksikMesaji($"{tablo.ViewCaption} Tablosu");

                return true;
            }

            return false;
        }
    }
}
