using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    // generic constraint
    // sadece classların gelmesi için filtre yazdık. Sadece db objesi gelebilir ya da IEntity olabilir.
    // new()' lenebilir. IEntity newlenemez.
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        // filtreler yazabilmemizi sağlıyor.
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);
    }
}
