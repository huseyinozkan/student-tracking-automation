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
    public class Kontenjan : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Kontenjan Adı", "txtKontenjanAdi")]
        public string KontenjanAdi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
