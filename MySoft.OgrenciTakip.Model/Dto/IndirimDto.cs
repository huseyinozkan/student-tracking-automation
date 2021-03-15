﻿using MySoft.OgrenciTakip.Model.Entities;
using MySoft.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySoft.OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class IndirimS : Indirim
    {
        public string IndirimTuruAdi { get; set; }
    }

    public class IndirimL : BaseEntity
    {
        public string IndirimAdi { get; set; }
        public long IndirimTuruId { get; set; }
        public string IndirimTuruAdi { get; set; }
        public string Aciklama { get; set; }
    }
}
