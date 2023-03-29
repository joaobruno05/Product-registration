using product_registration_PDI.Entities;
using System.Collections.Generic;

namespace product_registration_PDI.Interfaces
{
    public interface ICustomer
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public List<Product> Products { get; set; }
    }
}