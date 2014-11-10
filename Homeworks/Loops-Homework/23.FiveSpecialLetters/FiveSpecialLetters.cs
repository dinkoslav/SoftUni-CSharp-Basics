using System;

    class FiveSpecialLetters
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[] values = new int[5]{5,-12,47,7,-32};
            string[] letters = new string[5] {"a","b","c","d","e" };

            int[] emptyValues = new int[5];
            string[] emptyLetters = new string[5];
            int sum = 0;
            int total = 0;

            for (int firstIndex = 0; firstIndex < 5; firstIndex++)
            {
                int lettersUsed = 1;
                emptyLetters[0] = letters[firstIndex];
                emptyValues[lettersUsed-1] = values[firstIndex];
                sum = values[firstIndex] + sum;
                for (int secondIndex = 0; secondIndex < 5; secondIndex++)
                {
                    if (firstIndex != secondIndex)
                    {
                        lettersUsed++;
                        emptyValues[lettersUsed-1] = values[secondIndex];
                    }
                    
                    emptyLetters[1] = letters[secondIndex];
                    for (int thirdIndex = 0; thirdIndex < 5; thirdIndex++)
                    {
                        if (firstIndex != thirdIndex && thirdIndex != secondIndex)
                        {
                            lettersUsed++;
                            emptyValues[lettersUsed-1] = values[thirdIndex];
                        }
                        emptyLetters[2] = letters[thirdIndex];
                        for (int fourthIndex = 0; fourthIndex < 5; fourthIndex++)
                        {
                            if (fourthIndex != firstIndex && fourthIndex != secondIndex && fourthIndex != thirdIndex)
                            {
                                lettersUsed++;
                                emptyValues[lettersUsed-1] = values[fourthIndex];
                            }
                            emptyLetters[3] = letters[fourthIndex];
                            for (int fifthIndex = 0; fifthIndex < 5; fifthIndex++)
                            {
                                if (fifthIndex != firstIndex && fifthIndex != secondIndex && fifthIndex != thirdIndex && fifthIndex != fourthIndex)
                                {
                                    lettersUsed++;
                                    emptyValues[lettersUsed-1] = values[fifthIndex];
                                }
                                emptyLetters[4] = letters[fifthIndex];
                                sum = emptyValues[0] + (2 * emptyValues[1]) + (3 * emptyValues[2]) + (4 * emptyValues[3]) + (5 * emptyValues[4]);
                                if (sum >= n && sum <=m)
                                {
                                    if (total != 0)
                                    {
                                        Console.Write(" ");
                                    }
                                    for (int i = 0; i < emptyLetters.Length; i++)
                                    {
                                        Console.Write(emptyLetters[i]);
                                    }
                                    total++;
                                }
                                if (fifthIndex != firstIndex && fifthIndex != secondIndex && fifthIndex != thirdIndex && fifthIndex != fourthIndex)
                                {
                                    emptyValues[lettersUsed-1] = 0;
                                    lettersUsed--;
                                }
                            }
                            if (fourthIndex != firstIndex && fourthIndex != secondIndex && fourthIndex != thirdIndex)
                            {
                                emptyValues[lettersUsed-1] = 0;
                                lettersUsed--;
                            }
                        }
                        if (firstIndex != thirdIndex && thirdIndex != secondIndex)
                        {
                            emptyValues[lettersUsed-1] = 0;
                            lettersUsed--;
                        }
                    }
                    if (firstIndex != secondIndex)
                    {
                        emptyValues[lettersUsed-1] = 0;
                        lettersUsed--;
                    }
                }
                emptyValues[lettersUsed-1] = 0;
                lettersUsed--;
            }
            if (total == 0)
            {
                Console.WriteLine("No");
            }
        }
    }