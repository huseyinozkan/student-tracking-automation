using System.ComponentModel;

namespace MySoft.OgrenciTakip.Common.Enums
{
    public enum BankaHesapTuru : byte
    {
        [Description("Vadesiz Mevduat Hesabi")]
        VadesizMevduatHesabi = 1,
        [Description("Vadeli Mevduat Hesabi")]
        VadeliMevduatHesabi = 2,
        [Description("Kredi Hesabi")]
        KrediHesabi = 3,
        [Description("Epos Bloke Hesabi")]
        EposBlokeHesabi = 4,
        [Description("Ots Bloke Hesabi")]
        OtsBlokeHesabi = 5,
        [Description("Pos Bloke Hesabi")]
        PosBlokeHesabi = 6,
        [Description("Bloke Çözüm Hesabi")]
        BlokeCozumHesabi = 7
    }
}
