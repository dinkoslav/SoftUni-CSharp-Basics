using System;

class OddAndEvenJumps
    {
    static void Main()
        {
        string inputWord = Console.ReadLine();
        int odd = int.Parse(Console.ReadLine());
        int even = int.Parse(Console.ReadLine());
        char[] inputLetters = inputWord.ToCharArray();
        int j = 0;
        int oddPosition = 1;
        int evenPosition = 1;
        long oddSum = 0;
        long evenSum = 0;
        for (int i = 0; i < inputLetters.Length; i++)
            {
            if (inputLetters[i] != ' ')
                {
                if (j % 2 == 0)
                    {
                    long n = Convert.ToInt64(char.ToLower(inputLetters[i]));
                    if (oddPosition % odd != 0)
                        {
                        oddSum = oddSum + n;
                        oddPosition++;
                        }
                    else
                        {
                        oddSum = oddSum * n;
                        oddPosition = 1;
                        }
                    j++;
                    }
                else
                    {
                    long n = Convert.ToInt64(char.ToLower(inputLetters[i]));
                    if (evenPosition % even != 0)
                        {
                        evenSum = evenSum + n;
                        evenPosition++;
                        }
                    else
                        {
                        evenSum = evenSum * n;
                        evenPosition = 1;
                        }
                    j++;
                    }
                }
            }
        Console.WriteLine("Odd: {0:X}",oddSum);
        Console.WriteLine("Even: {0:X}", evenSum);
        }
    }

//using System;
//using System.Collections.Generic;

//class OddAndEvenJumps
//    {
//    static void Main()
//        {
//        string inputWord = Console.ReadLine();
//        char[] inputLetters = inputWord.ToCharArray();
//        int odd = int.Parse(Console.ReadLine());
//        int even = int.Parse(Console.ReadLine());
//        List<char> oddLetters = new List<char>();
//        List<char> evenLetters = new List<char>();
//        int j = 0;
//        long oddSum = 0;
//        long evenSum = 0;
//        for (int i = 0; i < inputLetters.Length; i++)
//            {
//            if (inputLetters[i] != ' ')
//                {
//                if (j % 2 == 0)
//                    {
//                    oddLetters.Add(char.ToLower(inputLetters[i]));
//                    j++;
//                    }
//                else
//                    {
//                    evenLetters.Add(char.ToLower(inputLetters[i]));
//                    j++;
//                    }
//                }
//            }
//        j = 1;
//        foreach (var number in oddLetters)
//            {
//            long n = Convert.ToInt64(number);
//            if (j%odd != 0)
//                {
//                oddSum = oddSum + n;
//                j++;
//                }
//            else
//                {
//                oddSum = oddSum * n;
//                j = 1;
//                }
//            }
//        j = 1;
//        foreach (var number in evenLetters)
//            {
//            long n = Convert.ToInt64(number);
//            if (j % even != 0)
//                {
//                evenSum = evenSum + n;
//                j++;
//                }
//            else
//                {
//                evenSum = evenSum * n;
//                j = 1;
//                }
//            }
//        Console.WriteLine("Odd: {0:X}",oddSum);
//        Console.WriteLine("Even: {0:X}", evenSum);
//        }
//    }