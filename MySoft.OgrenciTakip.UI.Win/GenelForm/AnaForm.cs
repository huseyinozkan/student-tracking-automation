﻿using DevExpress.XtraBars;
using MySoft.OgrenciTakip.UI.Win.Forms.OkulForms;
using MySoft.OgrenciTakip.UI.Win.Show;
using MySoft.OgrenciTakip.UI.Win.Forms.IlForms;
using MySoft.OgrenciTakip.UI.Win.Forms.AileBilgiForms;
using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.UI.Win.Forms.IptalNedeniForms;
using MySoft.OgrenciTakip.UI.Win.Forms.YabanciDilForms;
using MySoft.OgrenciTakip.UI.Win.Forms.TesvikForms;
using MySoft.OgrenciTakip.UI.Win.Forms.KontenjanForms;
using MySoft.OgrenciTakip.UI.Win.Forms.RehberForms;
using MySoft.OgrenciTakip.UI.Win.Forms.SinifGrupForms;
using MySoft.OgrenciTakip.UI.Win.Forms.MeslekForms;
using MySoft.OgrenciTakip.UI.Win.Forms.YakinlikForms;
using MySoft.OgrenciTakip.UI.Win.Forms.IsYeriForms;
using MySoft.OgrenciTakip.UI.Win.Forms.GorevForms;
using MySoft.OgrenciTakip.UI.Win.Forms.IndirimTuruForms;
using MySoft.OgrenciTakip.UI.Win.Forms.EvrakForms;
using MySoft.OgrenciTakip.UI.Win.Forms.PromosyonForms;
using MySoft.OgrenciTakip.UI.Win.Forms.ServisForms;
using MySoft.OgrenciTakip.UI.Win.Forms.SinifForms;
using MySoft.OgrenciTakip.UI.Win.Forms.HizmetTuruForms;
using System;
using MySoft.OgrenciTakip.UI.Win.Forms.HizmetForms;
using MySoft.OgrenciTakip.UI.Win.Forms.KasaForms;
using MySoft.OgrenciTakip.UI.Win.Forms.BankaForms;
using MySoft.OgrenciTakip.UI.Win.Forms.AvukatForms;
using MySoft.OgrenciTakip.UI.Win.Forms.CariForms;
using MySoft.OgrenciTakip.UI.Win.Forms.OdemeTuruForms;
using MySoft.OgrenciTakip.UI.Win.Forms.BankaHesapForms;
using MySoft.OgrenciTakip.UI.Win.Forms.IletisimForms;
using MySoft.OgrenciTakip.UI.Win.Forms.OgrenciForms;
using MySoft.OgrenciTakip.UI.Win.Forms.IndirimForms;
using MySoft.OgrenciTakip.UI.Win.Forms.TahakkukForms;
using MySoft.OgrenciTakip.UI.Win.Forms.MakbuzForms;

namespace MySoft.OgrenciTakip.UI.Win.GenelForm
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static long DonemId = 1;
        public static long SubeId = 1;
        public static string DonemAdi = "Dönem Bilgisi Bekleniyor...";
        public static string SubeAdi = "Şube Bilgisi Bekleniyor...";

        public static DateTime EgitimBaslamaTarihi = new DateTime(2019, 09, 15);
        public static DateTime DonemBaslamaTarihi = new DateTime(2019, 07, 01);
        public static DateTime DonemBitisTarihi = new DateTime(2020, 06, 30);
        public static bool GunTarihininOncesineHizmetBaslamaTarihiGirilebilir = true;
        public static bool GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir = true;
        public static bool GunTarihininOncesineIptalTarihiGirilebilir = true;
        public static bool GunTarihininSonrasinaIptalTarihiGirilebilir = true;
        public static bool GunTarihininOncesineMakbuzTarihiGirilebilir = true;
        public static bool GunTarihininSonrasinaMakbuzTarihiGirilebilir = true;
        public static bool HizmetTahakkukKurusKullan;
        public static bool IndirimTahakkukKurusKullan;
        public static bool OdemePlaniKurusKullan;
        public static bool GittigiOkulZorunlu = true;
        public static DateTime MaksimumTaksitTarihi = new DateTime(2020, 06, 30);
        public static byte MaksimumTaksitSayisi = 12;
        public static long? DefaultKasaHesapId;
        public static string DefaultKasaHesapAdi;
        public static long? DefaultBankaHesapId;
        public static string DefaultBankaHesapAdi;
        public static long? DefaultAvukatHesapId;
        public static string DefaultAvukatHesapAdi;
        public static long KullaniciId = 1;

        public AnaForm()
        {
            InitializeComponent();
            EventsLoad();
        }
        
        private void EventsLoad()
        {
            foreach (var item in ribbonControl.Items)
            {
                switch (item)
                {
                    case BarButtonItem btn:
                        btn.ItemClick += Butonlar_ItemClick;
                        break;
                }
            }
        }

        private void Butonlar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item == btnOkulKartlari)
                ShowListForms<OkulListForm>.ShowListForm(KartTuru.Okul);
            else if (e.Item == btnIlKartlari)
                ShowListForms<IlListForm>.ShowListForm(KartTuru.Il);
            else if (e.Item == btnAileBilgiKartlari)
                ShowListForms<AileBilgiListForm>.ShowListForm(KartTuru.AileBilgi);
            else if (e.Item == btnIptalNedeniKartlari)
                ShowListForms<IptalNedeniListForm>.ShowListForm(KartTuru.IptalNedeni);
            else if (e.Item == btnYabanciDilKartlari)
                ShowListForms<YabancıDilListForm>.ShowListForm(KartTuru.YabanciDil);
            else if (e.Item == btnTesvikKartlari)
                ShowListForms<TesvikListForm>.ShowListForm(KartTuru.Tesvik);
            else if (e.Item == btnKontenjanKartlari)
                ShowListForms<KontenjanListForm>.ShowListForm(KartTuru.Kontenjan);
            else if (e.Item == btnRehberKartlari)
                ShowListForms<RehberListForm>.ShowListForm(KartTuru.Rehber);
            else if (e.Item == btnSinifGrupKartlari)
                ShowListForms<SinifGrupListForm>.ShowListForm(KartTuru.SinifGrup);
            else if (e.Item == btnMeslekKartlari)
                ShowListForms<MeslekListForm>.ShowListForm(KartTuru.Meslek);
            else if (e.Item == btnYakinlikKartlari)
                ShowListForms<YakinlikListForm>.ShowListForm(KartTuru.Yakinlik);
            else if (e.Item == btnIsYeriKartlari)
                ShowListForms<IsYeriListForm>.ShowListForm(KartTuru.IsYeri);
            else if (e.Item == btnGorevKartlari)
                ShowListForms<GorevListForm>.ShowListForm(KartTuru.Gorev);
            else if (e.Item == btnIndirimTuruKartı)
                ShowListForms<IndirimTuruListForm>.ShowListForm(KartTuru.IndirimTuru);
            else if (e.Item == btnEvrakKartlari)
                ShowListForms<EvrakListForm>.ShowListForm(KartTuru.Evrak);
            else if (e.Item == btnPromosyonKartlari)
                ShowListForms<PromosyonListForm>.ShowListForm(KartTuru.Promosyon);
            else if (e.Item == btnServisKartlari)
                ShowListForms<ServisListForm>.ShowListForm(KartTuru.Servis);
            else if (e.Item == btnSinifKartlari)
                ShowListForms<SinifListForm>.ShowListForm(KartTuru.Sinif);
            else if (e.Item == btnHizmetTuruKartlari)
                ShowListForms<HizmetTuruListForm>.ShowListForm(KartTuru.HizmetTuru);
            else if (e.Item == btnHizmetKartlari)
                ShowListForms<HizmetListForm>.ShowListForm(KartTuru.Hizmet);
            else if (e.Item == btnKasaKartlari)
                ShowListForms<KasaListForm>.ShowListForm(KartTuru.Kasa);
            else if (e.Item == btnBankaKartlari)
                ShowListForms<BankaListForm>.ShowListForm(KartTuru.Banka);
            else if (e.Item == btnAvukatKartları)
                ShowListForms<AvukatListForm>.ShowListForm(KartTuru.Avukat);
            else if (e.Item == btnCariKartlar)
                ShowListForms<CariListForm>.ShowListForm(KartTuru.Cari);
            else if (e.Item == btnOdemeTuruKartlari)
                ShowListForms<OdemeTuruListForm>.ShowListForm(KartTuru.OdemeTuru);
            else if (e.Item == btnBankaHesapKartlari)
                ShowListForms<BankaHesapListForm>.ShowListForm(KartTuru.BankaHesap);
            else if (e.Item == btnIletisimKartlari)
                ShowListForms<IletisimListForm>.ShowListForm(KartTuru.Iletisim);
            else if (e.Item == btnOgrenciKartlari)
                ShowListForms<OgrenciListForm>.ShowListForm(KartTuru.Ogrenci);
            else if (e.Item == btnIndirimKartlari)
                ShowListForms<IndirimListForm>.ShowListForm(KartTuru.Indirim);
            else if (e.Item == btnTahakkukKartları)
                ShowListForms<TahakkukListForm>.ShowListForm(KartTuru.Tahakkuk);
            else if (e.Item == btnMakbuzKartlari)
                ShowListForms<MakbuzListForm>.ShowListForm(KartTuru.Makbuz);
        }
    }
}