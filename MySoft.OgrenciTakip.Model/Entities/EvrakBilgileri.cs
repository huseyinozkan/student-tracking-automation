using MySoft.OgrenciTakip.Model.Entities.Base;

namespace MySoft.OgrenciTakip.Model.Entities
{
    public class EvrakBilgileri : BaseHareketEntity
    {
        public long TahakkukId { get; set; }

        public long EvrakId { get; set; }

        public Evrak Evrak { get; set; }
    }
}
