using MySoft.OgrenciTakip.Model.Entities.Base;
using System.Collections;
using System.Collections.Generic;

namespace MySoft.OgrenciTakip.Bll.Interfaces
{
    public interface IBaseHareketGenelBll
    {
        bool Insert(IList<BaseHareketEntity> entities);
        bool Update(IList<BaseHareketEntity> entities);
        bool Delete(IList<BaseHareketEntity> entities);
    }
}
