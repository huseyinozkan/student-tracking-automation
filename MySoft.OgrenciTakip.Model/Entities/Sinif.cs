using MySoft.OgrenciTakip.Model.Attributes;
using MySoft.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoft.OgrenciTakip.Model.Entities
{
    public class Sinif : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Sınıf Adı", "txtSinifAdi")]
        public string SinifAdi { get; set; }

        [ZorunluAlan("Grup Adı", "txtGrup")]
        public long GrupId { get; set; }

        public int HedefOgrenciSayisi { get; set; }

        [Column(TypeName = "money")]
        public decimal HedefCiro { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        public long SubeId { get; set; }

        public SinifGrup Grup { get; set; } //Burada Grup un sonuna Id Ekleyip(GrupId) SinifGrup daki Id ile relation işlemi yapacak.

        public Sube Sube { get; set; }
    }
}
