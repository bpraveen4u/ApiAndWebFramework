using Sample.Fpp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Fpp.Data.Contract
{
    public interface IRepository<T> where T : IEntity
    {
        IEnumerable<T> GetAll(Func<T, bool> predicate = null);
        //T Get(Func<T, bool> predicate);
        T Get(int id);
        void Add(T entity);
        void Attach(T entity);
        void Delete(T entity);
    }
}
