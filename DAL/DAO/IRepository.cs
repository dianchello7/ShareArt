using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    interface IRepository<T> : IDisposable where T :class
    {
        IEnumerable<T> GetTheWholeList();
        T GetOne(int id);
        void Add(T item);
        void Edit(T item);
        void Delete(T item);

    }
}
