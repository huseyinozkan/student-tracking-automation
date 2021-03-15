using MySoft.Dal.Interfaces;
using MySoft.OgrenciTakip.Bll.Functions;
using MySoft.OgrenciTakip.Bll.Interfaces;
using MySoft.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace MySoft.OgrenciTakip.Bll.Base
{
    public class BaseHareketBll<T, TContext> : IBaseBll, IBaseHareketGenelBll where T : BaseHareketEntity where TContext : DbContext
    {
        #region Variable
        
        private IUnitOfWork<T> _uow;

        #endregion

        protected IQueryable<TResult> List<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);
            return _uow.Rep.Select(filter, selector);
        }

        public virtual bool Insert(IList<BaseHareketEntity> entities)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);

            _uow.Rep.Insert(entities.EntityListConvert<T>());
            return _uow.Save();
        }

        public virtual bool Update(IList<BaseHareketEntity> entities)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);
            
            _uow.Rep.Update(entities.EntityListConvert<T>());
            return _uow.Save();
        }

        public bool Delete(IList<BaseHareketEntity> entities)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);
           
            _uow.Rep.Delete(entities.EntityListConvert<T>());
            return _uow.Save();
        }

        #region Dispose

        public void Dispose()
        {
            _uow?.Dispose();
        }

        #endregion
    }
}
