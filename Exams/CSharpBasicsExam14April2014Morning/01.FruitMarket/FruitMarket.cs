using System;

    class FruitMarket
    {
        static void Main()
        {
            string inputDate = Console.ReadLine();
            double totalPrice = 0;

            for (int i = 0; i < 3; i++)
            {
                double discount = 0;
                if (inputDate == "Friday")
                {
                    discount = 0.1;
                }
                else if (inputDate == "Sunday")
                {
                    discount = 0.05;
                }

                double quantities = double.Parse(Console.ReadLine());
                string item = Console.ReadLine();
                if (item == "banana")
                {
                    if (inputDate == "Thursday")
                    {
                        discount = 0.3;
                    }
                    else if (inputDate == "Tuesday")
                    {
                        discount = 0.2;
                    }
                    totalPrice = totalPrice + ((quantities * 1.8) - (quantities * 1.8*discount));
                }
                else if (item == "cucumber")
	            {
                    if (inputDate == "Wednesday")
                    {
                        discount = 0.1;
                    }
                    totalPrice = totalPrice + ((quantities * 2.75) - (quantities * 2.75 * discount));
	            }
                else if (item == "tomato")
	            {
                    if (inputDate == "Wednesday")
                    {
                        discount = 0.1;
                    }
                    totalPrice = totalPrice + ((quantities * 3.2) - (quantities * 3.2 * discount));
	            }
                else if (item == "orange")
	            {
                    if (inputDate == "Tuesday")
                    {
                        discount = 0.2;
                    }
                    totalPrice = totalPrice + ((quantities * 1.6) - (quantities * 1.6 * discount));
	            }
                else if (item == "apple")
	            {
                    if (inputDate == "Tuesday")
                    {
                        discount = 0.2;
                    }
                    totalPrice = totalPrice + ((quantities * 0.86) - (quantities * 0.86 * discount));
	            }
            }
            
            Console.WriteLine("{0:F2}",totalPrice);
        }
    }