using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace MySoft.OgrenciTakip.Common.Message
{
    public class Messages
    {
        public static void HataMesaji(string hataMesaji)
        {
            XtraMessageBox.Show(hataMesaji, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void UyariMesaji(string uyariMesaji)
        {
            XtraMessageBox.Show(uyariMesaji, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult EvetSeciliEvetHayir(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        public static DialogResult HayirSeciliEvetHayir(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
        }

        public static DialogResult EvetSeciliEvetHayirIptal(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        public static DialogResult SilMesaj (string KartAdi)
        {
            return HayirSeciliEvetHayir($"Seçilen {KartAdi} Silinecektir. Onaylıyor musunuz?", "Silme Onayı");
        }

        public static DialogResult KapanisMesaj()
        {
            return EvetSeciliEvetHayirIptal("Yapilan Değişiklikler Kayıt Edilsin mi?", "Çıkış Onay");
        }

        public static DialogResult KayitMesaj()
        {
            return EvetSeciliEvetHayir("Yapilan Değişiklikler Kayıt Edilsin mi?", "Kayıt Onay");
        }

        public static void KartSecmemeUyariMesaji()
        {
            UyariMesaji("Lütfen Bir Kart Seçiniz.");
        }

        public static void MukerrerKayitHataMesaji(string alanAdi)
        {
            HataMesaji($"Girmiş Olduğunuz {alanAdi} Daha Önce Kullanılmıştır.");
        }

        public static void HataliVeriMesaji(string alanAdi)
        {
            HataMesaji($"{alanAdi} Alanına Geçerli Bir Değer Girmelisiniz.");
        }

        public static DialogResult TabloExportMesaj(string dosyaFormati)
        {
            return EvetSeciliEvetHayir($"İlgili Tablo, {dosyaFormati} Olarak Dışarı Aktarılacaktır Onaylıyor musunuz?", "Aktarım Onay");
        }

        public static void KartBulunamadiMesaj(string kartTuru)
        {
            UyariMesaji($"İşlem Yapılabilecek {kartTuru} Bulunamadı.");
        }

        public static void TabloEksikMesaji(string tabloAdi)
        {
            UyariMesaji($"{tabloAdi}nda Eksik Bilgi Girişi Var. Lütfen Kontrol Ediniz.");
        }

        public static void IptalHareketSilinemezMesaji()
        {
            HataMesaji("İptal Edilen Hareketler Silinemez.");
        }

        public static DialogResult IptalMesaj(string KartAdi)
        {
            return HayirSeciliEvetHayir($"Seçilen {KartAdi} İptal Edilecektir. Onaylıyor musunuz?", "Iptal Onayı");
        }

        public static DialogResult IptalGeriAlMesaj(string KartAdi)
        {
            return HayirSeciliEvetHayir($"Seçilen {KartAdi} Kartına Uygulanan İptal İşlemi Geri Alınacaktır. Onaylıyor musunuz?", "Iptal Gerial Onayı");
        }

        public static void SecimHataMesaji(string alanAdi)
        {
            HataMesaji($"{alanAdi} Seçimi Yapmalısınız.");
        }

        public static void OdemeBelgesiSilinemezMesj(bool dahaSonra)
        {
            UyariMesaji(dahaSonra
                ? "Ödeme Belgesinin Daha Sonra İşlem Görmüş Hareketleri Var. Ödeme Belgesi Silinemez."
                : "Ödeme Belgesinin işlem Görmüş Haraketleri Var. Ödeme Belgesi Silinemez.");
        }

        public static DialogResult RaporTasarimaGonderMesaj()
        {
            return HayirSeciliEvetHayir("Rapor Tasarım Görünümünde Açılacaktır. Onaylıyor musunuz?", "Onay");
        }
    }
}
