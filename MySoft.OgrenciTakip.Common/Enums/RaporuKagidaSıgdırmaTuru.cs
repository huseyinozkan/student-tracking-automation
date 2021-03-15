using System.ComponentModel;

namespace MySoft.OgrenciTakip.Common.Enums
{
    public enum RaporuKagidaSıgdırmaTuru : byte
    {
        [Description("Sütunları Daraltarak Sığdır")]
        SutunlariDaraltarakSıgdır = 1,
        [Description("Yazı Boyutunu Küçülterek Sığdır")]
        YaziBoyutunuKuculterekSıgdır = 2,
        [Description("İşlem Yapma")]
        IslemYapma = 3
    }
}