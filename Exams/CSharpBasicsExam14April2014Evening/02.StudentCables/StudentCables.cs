using System;

    class StudentCables
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int totalLength = 0;

            for (int i = 0; i < n; i++)
            {
                int length = int.Parse(Console.ReadLine());
                string measure = Console.ReadLine();
                if (measure == "meters")
                {
                    length = length * 100;
                }
                if (length >= 20)
                {
                    if (totalLength>0)
                    {
                        totalLength = totalLength - 3;
                    }
                    totalLength = totalLength + length;
                }
            }
            Console.WriteLine(totalLength/504);
            Console.WriteLine(totalLength%504);
        }
    }