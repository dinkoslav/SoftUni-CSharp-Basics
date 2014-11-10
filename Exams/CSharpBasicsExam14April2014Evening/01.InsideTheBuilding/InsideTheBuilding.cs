using System;

    class InsideTheBuilding
    {
        static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                decimal x = decimal.Parse(Console.ReadLine());
                decimal y = decimal.Parse(Console.ReadLine());

                if ((x>=0&&x<=3*h)&&(y>=0&&y<=h))
                {
                    Console.WriteLine("inside");
                }
                else if ((x>=h&&x<=2*h)&&(y>=h&&y<=4*h))
                {
                    Console.WriteLine("inside");
                }
                else
                {
                    Console.WriteLine("outside");
                }
            }
        }
    }
