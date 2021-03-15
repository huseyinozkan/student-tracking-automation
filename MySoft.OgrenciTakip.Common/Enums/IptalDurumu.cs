﻿using System.ComponentModel;

namespace MySoft.OgrenciTakip.Common.Enums
{
    public enum IptalDurumu : byte
    {
        [Description("İptal Edildi")]
        IptalEdildi = 1,
        [Description("Devam Ediyor")]
        DevamEdiyor = 2
    }
}
