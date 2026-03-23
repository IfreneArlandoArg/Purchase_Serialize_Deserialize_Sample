using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public interface ICreateRepository<T> where T : class
    {
        void Add(T item);
    }
}