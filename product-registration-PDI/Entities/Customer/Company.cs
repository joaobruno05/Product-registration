using System.Collections.Generic;

namespace product_registration_PDI.Entities
{
    public class Company : Customer
    {
        public string Cnpj { get; set; }

        public Company(string cnpj)
        {
            Cnpj = cnpj;
        }

        public Company(string name, string address, string cnpj) : base(name, address)
        {
            Cnpj = cnpj;
        }

        public Company(string name, string address, List<Product> products, string cnpj) : base(name, address, products)
        {
            Cnpj = cnpj;
        }

        public bool ValidateCnpj(string cnpj)
        {
            string resultCnpj = cnpj.Replace(".", "").Replace("/", "").Replace("-", "");

            return resultCnpj.Length == 14;
        }
    }
}
