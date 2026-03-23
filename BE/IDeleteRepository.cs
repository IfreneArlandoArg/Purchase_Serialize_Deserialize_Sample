using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public interface IDeleteRepository<T> where T : class
    {
        void Delete(T item);
    }
}