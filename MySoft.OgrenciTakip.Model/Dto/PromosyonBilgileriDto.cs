using MySoft.OgrenciTakip.Model.Entities;
using MySoft.OgrenciTakip.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySoft.OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class PromosyonBilgileriL : PromosyonBilgileri, IBaseHareketEntity
    {
        public string Kod { get; set; }
        public string PromosyonAdi { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}
