using System;

namespace product_registration_PDI.Interfaces
{
    interface IProduct
    {
        public Guid Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
