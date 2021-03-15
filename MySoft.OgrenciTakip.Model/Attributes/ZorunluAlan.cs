using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoft.OgrenciTakip.Model.Attributes
{
    public class ZorunluAlan : Attribute
    {
        public string Description { get; }
        public string ControlName { get; }

        /// <summary>
        /// Validation işlemleri sırasında zorunlu olan alanları işaretlemek için kullanılacak
        /// </summary>
        /// <param name="description"> Uyarı mesajında gösterilecek olan açıklama </param>
        /// <param name="controlName"> Uyarı mesajı sonrası focuslanılacak kontrol adı </param>
        public ZorunluAlan(string description, string controlName)
        {
            Description = description;
            ControlName = controlName;
        }
    }
}
