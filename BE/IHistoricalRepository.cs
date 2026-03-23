using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public interface IHistoricalRepository<T> : ICreateRepository<T>, IReadRepository<T>, IDeleteRepository<T> where T : class
    {
    }
}