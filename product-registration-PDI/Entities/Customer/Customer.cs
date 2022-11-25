using product_registration_PDI.Interfaces;
using System.Collections.Generic;

namespace product_registration_PDI.Entities
{
    class Customer : ICustomer
    {
        public string Name { get; set; }
        public int Idade { get; set; }
        public string Job { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public Customer(string name, List<Product> products)
        {
            Name = name;
            Products = products;
        }
    }
}
