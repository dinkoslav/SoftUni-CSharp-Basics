using System;

    class BankAccountData
    {
        static void Main()
        {
            string FirstName = "Dinko";
            string MiddleName = "Ivanov";
            string LastName = "Todorov";
            decimal AmountOfMoney = 9965522.987M;
            string BankName = "DSK";
            string IBAN = "IB394563BG23423444343";
            string FirstAssociatedCreditCard = "3847 1231 0090 1233";
            string SecondAssociatedCreditCard = "1233 6578 2653 4356";
            string ThirdAssociatedCreditCard = "7866 0000 0100 7889";

            Console.WriteLine("Client : {0} {1} {2}",FirstName, MiddleName, LastName);
            Console.WriteLine("Personal Bank : " + BankName);
            Console.WriteLine("IBAN : " + IBAN);
            Console.WriteLine("Amount Of Money : {0} leva", AmountOfMoney);
            Console.WriteLine("Associated Credit Cards :");
            Console.WriteLine("     1 : " + FirstAssociatedCreditCard);
            Console.WriteLine("     2 : " + SecondAssociatedCreditCard);
            Console.WriteLine("     3 : " + ThirdAssociatedCreditCard);
        }
    }
