using MySoft.OgrenciTakip.Model.Attributes;
using MySoft.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySoft.OgrenciTakip.Model.Entities
{
    public class IsYeri : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("İş Yeri Adı", "txtIsYeriAdi")]
        public string IsYeriAdi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
