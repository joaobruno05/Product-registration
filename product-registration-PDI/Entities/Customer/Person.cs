using System.Collections.Generic;

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
            string resultCpf = cpf.Replace(".", "").Replace("-", "");

            return resultCpf.Length == 11;
        }
    }
}