using MySoft.OgrenciTakip.Model.Entities.Base;

namespace MySoft.OgrenciTakip.Model.Entities
{
    public class KardesBilgileri : BaseHareketEntity
    {
        public long TahakkukId { get; set; }
        public long KardesTahakkukId { get; set; }
        public Tahakkuk KardesTahakkuk { get; set; }
    }
}
