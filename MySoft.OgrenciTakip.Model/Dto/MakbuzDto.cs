using MySoft.OgrenciTakip.Common.Enums;
using MySoft.OgrenciTakip.Model.Entities;
using MySoft.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoft.OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class MakbuzS: Makbuz
    {
        public string HesapAdi { get; set; }
    }

    public class MakbuzL: BaseEntity
    {
        public DateTime Tarih { get; set; }
        public MakbuzTuru MakbuzTuru { get; set; }
        public MakbuzHesapTuru HesapTuru { get; set; }
        public decimal MakbuzToplami { get; set; }
        public int HareketSayisi { get; set; }
        public string HesapAdi { get; set; }
    }
}
