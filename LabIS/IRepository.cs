using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabIS
{
    public interface IRepository<T>
    {
        void Add(T data);
        void Delete(int id);
        void Update(int id, T data);
        T Read(int id);

        IEnumerable<T> ReadAll();
    }
}