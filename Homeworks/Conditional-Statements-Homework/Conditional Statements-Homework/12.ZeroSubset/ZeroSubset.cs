using System;

    class ZeroSubset
    {
        static void Main()
        {
            string str = Console.ReadLine();
            string[] tokens = str.Split(' ');
            int count = 0;
            int[] convertedNumbers = Array.ConvertAll<string, int>(tokens, int.Parse);

            for (int i = 0; i < convertedNumbers.Length; i++)
            {
                for (int j = i+1; j < convertedNumbers.Length; j++)
                {
                    if (convertedNumbers[i] + convertedNumbers[j] == 0)
                    {
                        Console.WriteLine("{0} + {1} = 0", convertedNumbers[i], convertedNumbers[j]);
                        count++;
                    }
                    for (int k = j+1; k < convertedNumbers.Length; k++)
                    {
                        if (convertedNumbers[i] + convertedNumbers[j] + convertedNumbers[k] == 0)
                        {
                            Console.WriteLine("{0} + {1} + {2}= 0", convertedNumbers[i], convertedNumbers[j],convertedNumbers[k]);
                            count++;
                        }
                        for (int l = k+1; l < convertedNumbers.Length; l++)
                        {
                            if (convertedNumbers[i] + convertedNumbers[j] + convertedNumbers[k] + convertedNumbers[l] == 0)
                            {
                                Console.WriteLine("{0} + {1} + {2} + {3}= 0",
                                    convertedNumbers[i], convertedNumbers[j], convertedNumbers[k], convertedNumbers[l]);
                                count++;
                            }
                            for (int m = l+1; m < convertedNumbers.Length; m++)
                            {
                                if (convertedNumbers[i] + convertedNumbers[j] + convertedNumbers[k] + convertedNumbers[l] + convertedNumbers[m] == 0)
                                {
                                    Console.WriteLine("{0} + {1} + {2} + {3} + {4}= 0",
                                        convertedNumbers[i], convertedNumbers[j], convertedNumbers[k], convertedNumbers[l], convertedNumbers[m]);
                                    count++;
                                }
                            }
                        }
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("no zero subset");
            }
        }
    }
