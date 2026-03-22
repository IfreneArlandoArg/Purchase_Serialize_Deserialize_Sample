using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();

        void Add(T item);
    
        void Update(T item);
    
        void Delete(T item);
    }
}