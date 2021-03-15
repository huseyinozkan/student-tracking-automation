using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Model.Entities.Base.Interfaces;

namespace MySoft.OgrenciTakip.Model.Entities
{
    public class DokumParametreleri : IBaseEntity
    {
        public string RaporBaslik { get; set; }
        public EvetHayir BaslikEkle { get; set; }
        public RaporuKagidaSıgdırmaTuru RaporuKagidaSigdir { get; set; }
        public YazdirmaYonu YazdirmaYonu { get; set; }
        public EvetHayir YatayCizgileriGoster { get; set; }
        public EvetHayir DikeyCizgileriGoster { get; set; }
        public EvetHayir SutunBasliklariniGoster { get; set; }
        public string YaziciAdi { get; set; }
        public int YazdirilacakAdet { get; set; }
        public DokumSekli DokumSekli { get; set; }
    }
}