using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using DevFramework.Core.Entities;

namespace DevFramework.Core.DataAccess
{
    public interface IQueryableRepository<T> where T : class, IEntity, new()
    {
        IQueryable<T> Table { get; }
=======

namespace DevFramework.Core.DataAccess
{
    internal interface IQuaryableRepository
    {
>>>>>>> 16ff61320f35a2f68ff4266a2cb6f8f6696e2211
    }
}
