using product_registration_PDI.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace product_registration_PDI.HelpFunctions
{
    public static class RegisterProduct
    {
        public static List<Product> AddProducts()
        {
            List<Product> listProducts = new List<Product>();
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

            return listProducts;
        }
    }
}
