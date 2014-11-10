using System;

    class PrintTheASCIITable
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            for (int i = 0; i < 256; i++)
            {
                char c = (char)i;
                Console.Write(c + " ");
            }
        }
    }