using product_registration_PDI.Interfaces;
using System.Collections.Generic;
using System;

namespace product_registration_PDI.Entities
{
    public class Customer : ICustomer
    {
        //CPF ou CNPJ
        public string Register { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public Customer(string register, string name, string adress, List<Product> products)
        {
            Register = register;
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

        public double TotalPrice ()
        {
            double total = 0.0;
            foreach (Product product in Products)
            {
                total += product.Price; 
            }
            return total;
        }
    }
}
