using System.Collections.Generic;

namespace product_registration_PDI.Entities
{
    public class Person : Customer
    {
        public string Cpf { get; set; }
        
        public Person(string name, string adress, List<Product> products, string cpf) : base(name, adress, products)
        {
            Cpf = cpf;
        }

        public bool validateCpf(string cpf)
        {
            string resultCpf = cpf.Replace(".", "");
            resultCpf = resultCpf.Replace("-", "");

            if (resultCpf.Length != 11) return false;
            return true;
        }
    }
}