using MySoft.OgrenciTakip.Model.Entities.Base;

namespace MySoft.OgrenciTakip.Model.Entities
{
    public class PromosyonBilgileri : BaseHareketEntity
    {
        public long TahakkukId { get; set; }

        public long PromosyonId { get; set; }

        public Promosyon Promosyon { get; set; }
    }
}
