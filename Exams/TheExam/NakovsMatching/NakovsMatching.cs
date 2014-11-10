using System;

class NakovsMatching
    {
    static void Main()
        {
        string firstWord = Console.ReadLine();
        string secondWord = Console.ReadLine();
        int d = int.Parse(Console.ReadLine());
        int aLeft = 0;
        int aRight = 0;
        int bLeft = 0;
        int bRight = 0;
        int count = 0;

        for (int j = 1; j < firstWord.Length; j++)
            {
            for (int k = 1; k < secondWord.Length; k++)
                {
                for (int i = 0; i < firstWord.Length; i++)
                    {
                    int n = Convert.ToInt32(char.ToLower(firstWord[i]));
                    if (i < j)
                        {
                        aLeft = aLeft + n;
                        }
                    else
                        {
                        aRight = aRight + n;
                        }
                    }
                for (int l = 0; l < secondWord.Length; l++)
                    {
                    int m = Convert.ToInt32(char.ToLower(secondWord[l]));
                    if (l < k)
                        {
                        bLeft = bLeft + m;
                        }
                    else
                        {
                        bRight = bRight + m;
                        }
                    }
                int nakovNumber = Math.Abs((aLeft * bRight) - (aRight * bLeft));
                if (nakovNumber <= d)
                    {
                    Console.Write("(");
                    for (int firstPosition = 0; firstPosition < firstWord.Length; firstPosition++)
                        {
                        if (firstPosition == j)
                            {
                            Console.Write("|{0}", firstWord[firstPosition]);
                            }
                        else
                            {
                            Console.Write(firstWord[firstPosition]);
                            }
                        }
                    Console.Write(") matches (");
                    for (int secondPosition = 0; secondPosition < secondWord.Length; secondPosition++)
                        {
                        if (secondPosition == k)
                            {
                            Console.Write("|{0}", secondWord[secondPosition]);
                            }
                        else
                            {
                            Console.Write(secondWord[secondPosition]);
                            }
                        }
                    Console.Write(") by {0} nakovs", nakovNumber);
                    Console.WriteLine("");
                    count++;
                    }
                aLeft = 0;
                aRight = 0;
                bLeft = 0;
                bRight = 0;
                    }
                }
        if (count == 0)
            {
            Console.WriteLine("No");
            }
            }
        }
