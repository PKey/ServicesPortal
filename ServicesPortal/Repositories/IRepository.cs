using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesPortal.Repositories
{
    /// <summary>
    /// Intefejs bazowy
    /// </summary>
    public interface IRepository<T>
    {
        void Add(T element);
        void Delete(T element);
        void SaveChanges();
    }
}
