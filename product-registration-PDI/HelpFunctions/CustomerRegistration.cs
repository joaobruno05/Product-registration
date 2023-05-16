using product_registration_PDI.Entities;
using System;

namespace product_registration_PDI.HelpFunctions
{
    public static class CustomerRegistration
    {
        public static string[] RegisterUser()
        {
            Console.WriteLine("Digite o seu CPF:");
            string cpf = Console.ReadLine();
            Person user = new Person(cpf);
            bool isValidRegister = user.ValidateUser();
            while (!isValidRegister)
            {
                Console.WriteLine("CPF inválido. Tente novamente!");
                cpf = Console.ReadLine();
                Person newUser = new Person(cpf);
                isValidRegister = newUser.ValidateUser();
            }
            Console.WriteLine("Digite o seu nome completo:");
            string userName = Console.ReadLine();
            Console.WriteLine("Digite o endereço da sua residência:");
            string userAddress = Console.ReadLine();

            string[] objectUser = new string[2] { userName, userAddress };
            return objectUser;
        }

        public static string[] RegisterCompany()
        {
            Console.WriteLine("Digite o seu CNPJ:");
            string cnpj = Console.ReadLine();
            Company company = new Company(cnpj);
            bool isValidRegister = company.ValidateUser();
            while (!isValidRegister)
            {
                Console.WriteLine("CNPJ inválido. Digite um válido!");
                cnpj = Console.ReadLine();
                Company newCompany = new Company(cnpj);
                isValidRegister = newCompany.ValidateUser();
            }
            Console.WriteLine("Digite o nome da sua empresa:");
            string companyName = Console.ReadLine();
            Console.WriteLine("Digite o endereço da sua empresa:");
            string companyAddress = Console.ReadLine();

            string[] objectCompany = new string[2] { companyName, companyAddress };
            return objectCompany;
        }
    }
}
