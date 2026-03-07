using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class Purchase
    {
        public Guid IdPurchase { get; set; }
        public List<Product> Products { get; set; }
        public DateTime DateTime { get; set; }
        public decimal Total { get; set; }

        public Purchase()
        {
            
        }
        public Purchase(List<Product> products)
        {
            IdPurchase = Guid.NewGuid();
            Products = products;
            DateTime = DateTime.Now;
            Total = GetTotalPrice(Products);
        }

        private decimal GetTotalPrice(List<Product> products)
        {
            return products?.Sum(p => p.Price) ?? 0m;
        }

        public override string ToString()
        {
            var names = Products == null ? "no products" : string.Join("\n ", Products.Select(p =>  $"{p.Name} - {p.Price:C}"));
            return $"Products: \n {names} \n\nPurchase {IdPurchase} - {DateTime} - Total: {Total:C}";
        }
    }
}