using System;

    class MagicCarNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] letters = new int[10]{10,20,30,50,80,110,130,160,200,240};
            int total = 0;

            if (n < 60 || n>556)
            {
                Console.WriteLine(0);
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int m = 0; m < 10; m++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            for (int k = 0; k < 10; k++)
                            {
                                if (n == 40 + (3 * i)+(m) + letters[j] + letters[k])
                                {
                                    if (i==m)
                                    {
                                        total = total + 1;
                                    }
                                    else
                                    {
                                        total = total + 2;
                                    }
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < 10; i++)
                {
                    for (int m = 0; m < 10; m++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            for (int k = 0; k < 10; k++)
                            {
                                if (n == 40 + (2 * i) + (2*m) + letters[j] + letters[k] && m!=i)
                                {
                                    total = total + 3;
                                }
                            }
                        }
                    }
                }
                Console.WriteLine(total);
            }
        }
    }
