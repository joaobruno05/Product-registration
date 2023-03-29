using System;
using System.Collections.Generic;
using System.Text;

namespace product_registration_PDI.Entities
{
    class Company : Customer
    {
        public string Cnpj { get; set; }

        public Company(string name, string adress, List<Product> products, string cnpj) : base(name, adress, products)
        {
            Cnpj = cnpj;
        }

        public bool validateCnpj(string cnpj)
        {
            string resultCnpj = cnpj.Replace(".", "");
            resultCnpj = resultCnpj.Replace("-", "");

            if (resultCnpj.Length != 14) return false;
            return true;
        }
    }
}
}
