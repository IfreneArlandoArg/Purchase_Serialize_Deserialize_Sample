using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;
using DAL;

namespace BLL
{
    public class BLLPurchase : IHistoricalRepository<Purchase>
    {
        readonly IHistoricalRepository<Purchase> _repository;

        public BLLPurchase()
        {
            _repository = new DALPurchase();
        }
        public void Add(Purchase item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Purchase item)
        {
            throw new NotImplementedException();
        }

        public List<Purchase> GetAll()
        {
            return _repository.GetAll();
        }
    }
}