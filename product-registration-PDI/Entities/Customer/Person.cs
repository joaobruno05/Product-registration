using product_registration_PDI.Interfaces;
using System.Collections.Generic;
using System.Globalization;

namespace product_registration_PDI.Entities
{
    public class Person : Customer
    {
        public string Cpf { get; set; }

        public Person(string cpf)
        {
            Cpf = cpf;
        }
        public Person(string name, string address, string cpf) : base(name, address)
        {
            Cpf = cpf;
        }

        public Person(string name, string address, List<Product> products, string cpf) : base(name, address, products)
        {
            Cpf = cpf;
        }

        public bool ValidateCpf(string cpf)
        {
            string resultCpf = cpf.Replace(".", "");
            resultCpf = resultCpf.Replace("-", "");

            if (resultCpf.Length != 11) return false;
            return true;
        }
    }
}