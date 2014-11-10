using System;

    class WineGlass
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{0}",new string('.',i),"\\",new string('*',n-(2*i)-2),"/");
            }
            if (n<12)
            {
                for (int i = 0; i < (n/2)-1; i++)
                {
                    Console.WriteLine("{0}{1}{0}",new string('.',(n-2)/2),"||");
                }
                Console.WriteLine("{0}",new string('-',n));
            }
            else if (n>=12)
            {
                for (int i = 0; i < (n/2)-2; i++)
                {
                    Console.WriteLine("{0}{1}{0}",new string('.',(n-2)/2),"||");
                }
                Console.WriteLine("{0}", new string('-',n));
                Console.WriteLine("{0}", new string('-', n));
            }
        }
    }