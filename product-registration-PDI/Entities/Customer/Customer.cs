using product_registration_PDI.Interfaces;
using System.Collections.Generic;
using System;
using System.Globalization;

namespace product_registration_PDI.Entities
{
    public class Customer : ICustomer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string RegistrationNumber { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public Customer()
        {
        }

        public Customer(string registrationNumber)
        {
            RegistrationNumber = registrationNumber;
        }

        public Customer(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public Customer(string name, string address, string registrationNumber)
        {
            Name = name;
            Address = address;
            RegistrationNumber = registrationNumber;
        }

        public virtual bool ValidateUser()
        {
            return true;
        }

        public string MaskRegistrationNumber(string clientType)
        {
            string cpfOrCnpj = clientType == "PF" ? "CPF" : "CNPJ";
            string maskedRegistrationNumber;
            if (cpfOrCnpj == "CPF")
            {
                maskedRegistrationNumber = $"{RegistrationNumber.Substring(0, 3)}.XXX.XXX-XX";
            }
            else
            {
                maskedRegistrationNumber = $"{RegistrationNumber.Substring(0, 2)}.{RegistrationNumber.Substring(2, 3)}.XXX/XXXX-XX'";
            }
            return $"{cpfOrCnpj}: {maskedRegistrationNumber}";
        }

        public string CustomerPersonalData(string clientType)
        {
            return $"Nome cliente: {Name}{Environment.NewLine}Endereço: {Address}{Environment.NewLine}{MaskRegistrationNumber(clientType)}";
        }

        public void FormatProductsTable(List<Product> products)
        {
            string result;
            int index = 1;
            foreach (Product product in products)
            {
                result =  $"Produto {index++}\r\n" +
                          $"Código - {product.Code}\r\n" +
                          $"Nome - {product.Name}\r\n" +
                          $"Preço - R${product.Price.ToString("F2", CultureInfo.InvariantCulture)}";
                Console.WriteLine(result);
                Console.WriteLine("--------------------------------");
            }
        }

        public string TotalPrice(List<Product> products)
        {
            double total = 0.0;
            foreach (Product product in products)
            {
                total += product.Price;
            }
            return $"O valor total da compra foi igual a R${total.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
