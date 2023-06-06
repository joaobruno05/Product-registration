using System.Collections.Generic;
using System;

namespace product_registration_PDI.Entities
{
    public class Person : Customer
    {
        public Person()
        {

        }
        public Person(string registrationNumber) : base(registrationNumber)
        {
            RegistrationNumber = registrationNumber;
        }
        public Person(string name, string address, string registrationNumber) : base(name, address, registrationNumber)
        {
            RegistrationNumber = registrationNumber;
        }

        public override bool ValidateUser(int charactersNumbers = 11)
        {
            string resultCpf = RegistrationNumber.Replace(".", "").Replace("-", "");

            return resultCpf.Length == charactersNumbers;
        }
    }
}