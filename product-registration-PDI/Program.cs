using product_registration_PDI.Entities;
using System.Collections.Generic;
using System;
using System.Globalization;

namespace product_registration_PDI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> listProducts = new List<Product>();
            Customer customer = new Customer();

            Console.WriteLine("Vamos começar a colocar suas compras no carrinho :)");

            int registerTry = 0;
            string register;
            do
            {
                Console.WriteLine("Digite 'PF' para pessoa física ou 'PJ' para pessoa jurídica!");
                register = Console.ReadLine().ToUpper();
                registerTry += 1;
            } while (register != "PF" && register != "PJ" && registerTry < 3);

            if (registerTry >= 3)
            {
                Console.WriteLine("Desculpe, estou encerrando nossa conversa. Tente novamente mais tarde.");
            }

            if (register == "PF")
            {
                Console.WriteLine("Digite o seu CPF:");
                string cpf = Console.ReadLine();
                Person user = new Person(cpf);
                bool isValidRegister = user.ValidateCpf(cpf);
                while (!isValidRegister)
                {
                    Console.WriteLine("CPF inválido. Tente novamente!");
                    cpf = Console.ReadLine();
                    isValidRegister = user.ValidateCpf(cpf);
                }
                Console.WriteLine("Digite o seu nome completo:");
                string userName = Console.ReadLine();
                Console.WriteLine("Digite o endereço da sua residência:");
                string userAddress = Console.ReadLine();
                customer.Name = userName;
                customer.Address = userAddress;
            }

            if (register == "PJ")
            {
                Console.WriteLine("Digite o seu CNPJ:");
                string cnpj = Console.ReadLine();
                Company company = new Company(cnpj);
                bool isValidRegister = company.ValidateCnpj(cnpj);
                while (!isValidRegister)
                {
                    Console.WriteLine("CNPJ inválido. Digite um válido!");
                    cnpj = Console.ReadLine();
                    isValidRegister = company.ValidateCnpj(cnpj);
                }
                Console.WriteLine("Digite o nome da sua empresa:");
                string companyName = Console.ReadLine();
                Console.WriteLine("Digite o endereço da sua empresa:");
                string companyAddress = Console.ReadLine();
                customer.Name = companyName;
                customer.Address = companyAddress;
            }

            char input = 'n';
            while (input == 'n')
            {
                Console.Write("Digite o nome do produto a ser adicionado na lista: ");
                string productName = Console.ReadLine();

                Console.Write("Digite o preço do produto: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                listProducts.Add(new Product(productName, price));

                Console.WriteLine("Deseja finalizar? s / n");
                char result = char.Parse(Console.ReadLine());

                if (result == 's') input = 's';
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Carrinho:");
            Console.WriteLine(customer.CustomerPersonalData());
            Console.WriteLine("--------------------------------");
            customer.FormatProductsTable(listProducts);
            Console.WriteLine("--------------------------------");
            Console.WriteLine(customer.TotalPrice(listProducts));
        }
    }
}