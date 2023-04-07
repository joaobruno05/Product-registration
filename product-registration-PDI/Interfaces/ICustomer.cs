using product_registration_PDI.Entities;
using System.Collections.Generic;

namespace product_registration_PDI.Interfaces
{
    public interface ICustomer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Product> Products { get; set; }

        public string CustomerPersonalData();
        public void FormatProductsTable(List<Product> products);
        public string TotalPrice(List<Product> products);
    }
}