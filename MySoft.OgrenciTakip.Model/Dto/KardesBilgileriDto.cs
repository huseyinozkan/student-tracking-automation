using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Model.Entities;
using MySoft.OgrenciTakip.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySoft.OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class KardesBilgileriL : KardesBilgileri , IBaseHareketEntity
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string SinifAdi { get; set; }
        public KayitSekli KayitSekli { get; set; }
        public KayitDurumu KayitDurumu { get; set; }
        public IptalDurumu IptalDurumu { get; set; }
        public long SubeId { get; set; }
        public string SubeAdi { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}
