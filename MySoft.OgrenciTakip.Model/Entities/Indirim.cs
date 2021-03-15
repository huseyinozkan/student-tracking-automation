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
    public class Indirim : BaseEntityDurum
    {

        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("İndirim Adı", "txtIndirimAdi")]
        public string IndirimAdi { get; set; }

        [ZorunluAlan("İndirim Türü Adı", "txtIndirimTuru")]
        public long IndirimTuruId { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        public long SubeId { get; set; }

        public long DonemId { get; set; }

        public IndirimTuru IndirimTuru { get; set; }

        public Sube Sube { get; set; }

        public Donem Donem { get; set; }

        [InverseProperty("Indirim")]
        public ICollection<IndiriminUygulanacagiHizmetBilgileri> IndiriminUygulanacagiHizmetBilgileri { get; set; }
    }
}
