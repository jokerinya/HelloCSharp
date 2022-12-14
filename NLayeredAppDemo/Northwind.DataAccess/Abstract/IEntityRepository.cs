using Northwind.Entities.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstract
{
    // T can be newed, a class and IEntity derived class
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        // may not give any filter
        //List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        // give the filter
        //T Get(int id);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
