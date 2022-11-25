using product_registration_PDI.Interfaces;
using System;

namespace product_registration_PDI.Entities
{
    class Product : IProduct
    {
        public Guid Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(Guid code, string name, double price)
        {
            Code = Guid.NewGuid();
            Name = name;
            Price = price;
        }
    }
}
