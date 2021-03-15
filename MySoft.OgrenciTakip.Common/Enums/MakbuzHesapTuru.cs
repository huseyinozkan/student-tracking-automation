using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoft.OgrenciTakip.Common.Enums
{
    public enum MakbuzHesapTuru : byte
    {
        [Description("Avukat")]
        Avukat = 1,
        [Description("Banka")]
        Banka = 2,
        [Description("Cari")]
        Cari = 3,
        [Description("Epos")]
        Epos = 4,
        [Description("İade")]
        İade = 5,
        [Description("Kasa")]
        Kasa = 6,
        [Description("Mahsup")]
        Mahsup = 7,
        [Description("Ots")]
        Ots = 8,
        [Description("Pos")]
        Pos = 9,
        [Description("Şüpheli")]
        Supheli = 10,
        [Description("Transfer")]
        Transfer = 11
    }
}
