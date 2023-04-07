using product_registration_PDI.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace product_registration_PDI.Entities
{
    public class Product : IProduct
    {
        public Guid Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Code = Guid.NewGuid();
            Name = name;
            Price = price;
        }

        public string TotalPrice(List<Product> products)
        {
            double total = 0.0;
            foreach (Product product in products)
            {
                total += product.Price;
            }
            return $"O valor total da sua compra foi R$ {total.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
