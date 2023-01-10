using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using DevFramework.Core.Entities;
=======
>>>>>>> 16ff61320f35a2f68ff4266a2cb6f8f6696e2211

namespace DevFramework.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        // User can send a filter or it is default null
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter = null);
        T Add (T entity);
        T Update(T entity);
        void Delete (T entity);
    }
}
