using System;

namespace product_registration_PDI.HelpFunctions
{
    public class CustomerType
    {
        public static string ChooseCustomerType()
        {
            int registerTry = 0;
            string clientType;
            do
            {
                Console.WriteLine("Digite 'PF' para pessoa física ou 'PJ' para pessoa jurídica!");
                clientType = Console.ReadLine().ToUpper();
                registerTry += 1;
            } while (clientType != "PF" && clientType != "PJ" && registerTry < 3);

            if (registerTry >= 3)
            {
                Console.WriteLine("Desculpe, estou encerrando nossa conversa. Tente novamente mais tarde.");
                clientType = "Other";
            }

            return clientType;
        }
    }
}
