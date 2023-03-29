using product_registration_PDI.Interfaces;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Globalization;

namespace product_registration_PDI.Entities
{
    public class Customer : ICustomer
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public Customer(string name, string adress, List<Product> products)
        {
            Name = name;
            Adress = adress;
            Products = products;
        }

        public void AddProduct (Product product)
        {
            Products.Add(product);
        }

        public void RemoveProduct (Product product)
        {
            Products.Remove(product);
            
        }

        public string TotalPrice ()
        {
            double total = 0.0;
            foreach (Product product in Products)
            {
                total += product.Price;
            }
            return $"O valor total foi igual a R$ {total.ToString("F2", CultureInfo.InvariantCulture)},00";
        }
    }
}
