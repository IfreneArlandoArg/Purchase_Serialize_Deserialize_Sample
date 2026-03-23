using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{

    public interface IRepository<T>: IHistoricalRepository<T>, IUpdateRepository<T> where T : class
    {
       
    }

    public interface IRepository<T, TKey>: IRepository<T> where T : class
    {
        T GetById(TKey id);
    }
}