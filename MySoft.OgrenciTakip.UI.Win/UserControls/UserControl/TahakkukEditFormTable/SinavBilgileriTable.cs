using MySoft.OgrenciTakip.Bll.General;
using MySoft.OgrenciTakip.Common.Message;
using MySoft.OgrenciTakip.Model.Dto;
using MySoft.OgrenciTakip.UI.Win.Functions;
using MySoft.OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System;

namespace MySoft.OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class SinavBilgileriTable : BaseTablo
    {
        public SinavBilgileriTable()
        {
            InitializeComponent();

            Bll = new SinavBilgileriBll();
            Tablo = tablo;
            EventLoad();
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((SinavBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<SinavBilgileriL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;

            var row = new SinavBilgileriL
            { // Sadece dolu gelmesi istenen bilgiler eklenecek.
                TahakkukId = OwnerForm.Id,
                Tarih = DateTime.Now.Date,
                Insert = true
            };

            source.Add(row);
            
            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colSinavAdi;

            ButonEnabledDurum(true);
        }

        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            insUptNavigator.Navigator.Buttons.DoClick(insUptNavigator.Navigator.Buttons.EndEdit);
            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<SinavBilgileriL>(i);
                if (string.IsNullOrEmpty(entity.SinavAdi))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colSinavAdi;
                    tablo.SetColumnError(colSinavAdi, "Sınav Adı Alanına Geçerli Bir Değer Giriniz.");
                }
                if (string.IsNullOrEmpty(entity.PuanTuru))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colPuanTuru;
                    tablo.SetColumnError(colPuanTuru, "Puan Türü Alanına Geçerli Bir Değer Giriniz.");
                }

                if (!tablo.HasColumnErrors) continue;

                Messages.TabloEksikMesaji($"{tablo.ViewCaption} Tablosu");

                return true;
            }

            return false;
        }
    }
}
