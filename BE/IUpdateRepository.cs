using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public interface IUpdateRepository <T> where T : class
    {
        void Update(T item);
    }
}