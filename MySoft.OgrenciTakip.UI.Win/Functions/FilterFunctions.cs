using MySoft.OgrenciTakip.Model.Entities.Base;
using System;
using System.Linq.Expressions;

namespace MySoft.OgrenciTakip.UI.Win.Functions
{
    public class FilterFunctions
    {
        public static Expression<Func<T, bool>> Filter<T>(bool aktifKartlarGoster) where T : BaseEntityDurum
        {
            return x => x.Durum == aktifKartlarGoster;
        }

        public static Expression<Func<T, bool>> Filter<T>(long id) where T : BaseEntity
        {
            return x => x.Id == id;
        }
    }
}
