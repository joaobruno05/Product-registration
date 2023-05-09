using product_registration_PDI.Interfaces;
using System.Collections.Generic;
using System;
using System.Globalization;

namespace product_registration_PDI.Entities
{
    public class Customer : ICustomer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public Customer()
        {
        }

        public Customer(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public Customer(string name, string address, List<Product> products)
        {
            Name = name;
            Address = address;
            Products = products;
        }

        public string CustomerPersonalData()
        {
            return $"Nome cliente: {Name}{Environment.NewLine}Endereço: {Address}";
        }

        public void FormatProductsTable(List<Product> products)
        {
            string result;
            int index = 1;
            foreach (Product product in products)
            {
                result =  $"Produto {index++}\r\n" +
                          $"Código - {product.Code}\r\n" +
                          $"Nome - {product.Name}\r\n" +
                          $"Preço - R${product.Price}";
                Console.WriteLine(result);
                Console.WriteLine("--------------------------------");
            }
        }

        public string TotalPrice(List<Product> products)
        {
            double total = 0.0;
            foreach (Product product in products)
            {
                total += product.Price;
            }
            return $"O valor total foi igual a R${total.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
