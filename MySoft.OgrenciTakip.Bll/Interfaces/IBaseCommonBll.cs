using MySoft.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoft.OgrenciTakip.Bll.Interfaces
{
    public interface IBaseCommonBll
    {
        bool Delete(BaseEntity entity);
    }
}
