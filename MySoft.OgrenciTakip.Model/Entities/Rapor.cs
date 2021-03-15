﻿using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Model.Attributes;
using MySoft.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySoft.OgrenciTakip.Model.Entities
{
    public class Rapor : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Rapor Adı", "txtRaporAdi")]
        public string RaporAdi { get; set; }

        public KartTuru RaporTuru { get; set; }

        public RaporBolumTuru RaporBolumTuru { get; set; }

        [Required]
        public byte[] Dosya { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
