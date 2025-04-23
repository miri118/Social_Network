using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IRepository<T>
    {
        T GetById(int id);
        List<T> GetAll();
        T Add(T item);
        void Update(int id, T item);
        void Delete(int id);

    }
}
