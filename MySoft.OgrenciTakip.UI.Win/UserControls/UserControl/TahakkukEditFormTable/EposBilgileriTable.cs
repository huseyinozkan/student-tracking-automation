using DevExpress.XtraGrid.Views.Base;
using MySoft.OgrenciTakip.Bll.General;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Common.Message;
using MySoft.OgrenciTakip.Model.Dto;
using MySoft.OgrenciTakip.UI.Win.Functions;
using MySoft.OgrenciTakip.UI.Win.UserControls.UserControl.Base;

namespace MySoft.OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class EposBilgileriTable : BaseTablo
    {
        public EposBilgileriTable()
        {
            InitializeComponent();

            Bll = new EposBilgileriBll();
            Tablo = tablo;
            EventLoad();

            repositoryKartTuru.Items.AddEnum<EposKartTuru>();
        }
        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((EposBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<EposBilgileriL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            var row = new EposBilgileriL
            {
                TahakkukId = OwnerForm.Id,
                Insert = true
            };

            source.Add(row);
            

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colAdi;

            ButonEnabledDurum(true);
        }

        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();
            insUptNavigator.Navigator.Buttons.DoClick(insUptNavigator.Navigator.Buttons.EndEdit);
            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<EposBilgileriL>(i);
                if (string.IsNullOrEmpty(entity.Adi))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colAdi;
                    tablo.SetColumnError(colAdi, "Kart Sahibinin Adı Alanına Geçerli Bir Değer Giriniz.");
                }

                if (string.IsNullOrEmpty(entity.Soyadi))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colSoyadi;
                    tablo.SetColumnError(colSoyadi, "Kart Sahibinin Soyadı Alanına Geçerli Bir Değer Giriniz.");
                }

                if (string.IsNullOrEmpty(entity.BankaAdi))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colBankaAdi;
                    tablo.SetColumnError(colBankaAdi, "Banka Adı Alanına Geçerli Bir Değer Giriniz.");
                }

                if (string.IsNullOrEmpty(entity.KartNo))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colKartNo;
                    tablo.SetColumnError(colKartNo, "Kart Numarası Alanına Geçerli Bir Değer Giriniz.");
                }

                if (string.IsNullOrEmpty(entity.SonKullanmaTarihi))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colSonKullanmaTarihi;
                    tablo.SetColumnError(colSonKullanmaTarihi, "Son Kullanma Tarihi Alanına Geçerli Bir Değer Giriniz.");
                }

                if (string.IsNullOrEmpty(entity.GuvenlikKodu))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colGuvenlikKodu;
                    tablo.SetColumnError(colGuvenlikKodu, "Güvenlik Kodu Alanına Geçerli Bir Değer Giriniz.");
                }

                if (!tablo.HasColumnErrors) continue;

                Messages.TabloEksikMesaji($"{tablo.ViewCaption} Tablosu");

                return true;
            }

            return false;
        }

        // button edite tıklandığında yapılacak işlemler
        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colBankaAdi)
                e.FocusedColumn.Sec(tablo, insUptNavigator.Navigator, repositoryBanka, colBankaId);

        }
    }
}
