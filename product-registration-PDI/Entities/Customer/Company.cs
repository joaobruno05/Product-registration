using System.Collections.Generic;
using System;

namespace product_registration_PDI.Entities
{
    public class Company : Customer
    {
        public Company()
        {

        }
        public Company(string registrationNumber) : base(registrationNumber)
        {
            RegistrationNumber = registrationNumber;
        }

        public Company(string name, string address, string registrationNumber) : base(name, address, registrationNumber)
        {
            RegistrationNumber = registrationNumber;
        }

        public override bool ValidateUser()
        {
            string resultCnpj = RegistrationNumber.Replace(".", "").Replace("/", "").Replace("-", "");

            return resultCnpj.Length == 14;
        }
    }
}
