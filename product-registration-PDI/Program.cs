﻿using product_registration_PDI.Entities;
using System;
using product_registration_PDI.HelpFunctions;

namespace product_registration_PDI
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Customer customer = new Customer();

            Console.WriteLine("Vamos começar a colocar suas compras no carrinho :)");

            string clientType = CustomerType.ChooseCustomerType();
            string[] customerRegister = new string[3];

            if (clientType != "Other")
            {
                if (clientType == "PF")
                {
                    customerRegister = CustomerRegistration.RegisterUser();
                }
                if (clientType == "PJ")
                {
                    customerRegister = CustomerRegistration.RegisterCompany();
                }

                customer.Name = customerRegister[0];
                customer.Address = customerRegister[1];
                customer.RegistrationNumber = customerRegister[2];
                

                var listProducts = RegisterProduct.ListAddedProducts();

                Console.WriteLine("--------------------------------");
                Console.WriteLine("Carrinho:");
                Console.WriteLine(customer.CustomerPersonalData(clientType));
                Console.WriteLine("--------------------------------");
                customer.FormatProductsTable(listProducts);
                Console.WriteLine(customer.TotalPrice(listProducts));
            }
        }
    }
}