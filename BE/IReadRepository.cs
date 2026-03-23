using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public interface IReadRepository<T> where T : class
    {
        List<T> GetAll();
    }
}