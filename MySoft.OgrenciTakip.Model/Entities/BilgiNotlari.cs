using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoft.OgrenciTakip.Model.Entities.Base
{
    public class BilgiNotlari : BaseHareketEntity
    {
        public long TahakkukId { get; set; }

        public DateTime Tarih { get; set; }

        [Required, StringLength(1000)]
        public string BilgiNotu { get; set; }
    }
}
