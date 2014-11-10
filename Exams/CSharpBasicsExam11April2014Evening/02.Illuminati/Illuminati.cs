using System;

    class Illuminati
    {
        static void Main()
        {
            string inputText = Console.ReadLine();
            int vowels = 0;
            int sum = 0;
            for (int i = 0; i < inputText.Length; i++)
            {
                if (inputText[i] == 'A' || inputText[i] == 'a')
                {
                    vowels++;
                    sum = sum + 65;
                }
                else if (inputText[i] == 'E' || inputText[i] == 'e')
                {
                    vowels++;
                    sum = sum + 69;
                }
                else if (inputText[i] == 'I' || inputText[i] == 'i')
                {
                    vowels++;
                    sum = sum + 73;
                }
                else if (inputText[i] == 'O' || inputText[i] == 'o')
                {
                    vowels++;
                    sum = sum + 79;
                }
                else if (inputText[i] == 'U' || inputText[i] == 'u')
                {
                    vowels++;
                    sum = sum + 85;
                }
            }
            Console.WriteLine(vowels);
            Console.WriteLine(sum);
        }
    }