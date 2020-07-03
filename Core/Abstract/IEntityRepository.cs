using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.Abstract
{
   public interface IEntityRepository<T>
    {
        List<T> GetList(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T Entity);
        void Update(T Entity);
        void Delete(T Entity);

    }
}
