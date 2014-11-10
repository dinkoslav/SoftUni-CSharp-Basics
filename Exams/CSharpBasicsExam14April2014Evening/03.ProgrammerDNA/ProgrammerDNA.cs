using System;

    class ProgrammerDNA
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string letter = Console.ReadLine();
            int index = 0;
            int dots = 3;
            int descending = 1;

            string[] letters = new string[7] { "A", "B", "C", "D", "E", "F", "G"};
            for (int i = 0; i < 7; i++)
            {
                if (letters[i]==letter)
                {
                    index = i;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', dots));
                for (int j = 0; j < (7-(2*dots)); j++)
                {
                    Console.Write(letters[index]);
                    index++;
                    if (index == 7)
                    {
                        index = 0;
                    }
                }
                Console.Write(new string('.', dots));
                if (descending == 1 && dots > 0)
                {
                    dots--;
                }
                else if (descending == 0 && dots < 3)
                {
                    dots++;
                }
                else if (dots==0 || dots==3)
                {
                    if (descending == 1)
                    {
                        descending = 0;
                        dots++;
                    }
                    else if (descending == 0)
                    {
                        descending = 1;
                    }
                }
                Console.WriteLine("");
            }
        }
    }
