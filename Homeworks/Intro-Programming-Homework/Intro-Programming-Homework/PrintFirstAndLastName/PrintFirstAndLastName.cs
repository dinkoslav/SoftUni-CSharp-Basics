using System;

    class PrintFirstAndLastName
    {
        static void Main()
        {
            Console.WriteLine("Enter First Name:");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            string LastName = Console.ReadLine();
            Console.WriteLine("Your Full Name is {0} {1}",FirstName ,LastName);
        }
    }
