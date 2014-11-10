using System;
using System.Numerics;
    class CrossingSequences
    {
        static void Main()
        {
            int tribunachiFirst = int.Parse(Console.ReadLine());
            int tribunachiSecond = int.Parse(Console.ReadLine());
            int tribunachiThird = int.Parse(Console.ReadLine());
            int spiralNumber = int.Parse(Console.ReadLine());
            int spiralStep = int.Parse(Console.ReadLine());
            int spiralJump = 1;
            int spiralTurn = 0;

            int tribunachiFourth = tribunachiFirst + tribunachiSecond + +tribunachiThird;

            if (spiralNumber == tribunachiFirst || spiralNumber == tribunachiSecond || spiralNumber == tribunachiThird)
            {
                Console.WriteLine(spiralNumber);
            }
            else
            {
                while (spiralNumber != tribunachiFourth && spiralNumber != tribunachiFirst 
                    && spiralNumber != tribunachiSecond && spiralNumber != tribunachiThird 
                    && tribunachiFourth <= 1000000 && spiralNumber <= 1000000)
                {
                    if (spiralNumber > tribunachiFourth)
                    {
                        tribunachiFirst = tribunachiSecond;
                        tribunachiSecond = tribunachiThird;
                        tribunachiThird = tribunachiFourth;
                        tribunachiFourth = tribunachiFirst + tribunachiSecond + +tribunachiThird;
                    }
                    else
                    {
                        spiralNumber = spiralNumber + spiralStep * spiralJump;
                        if (spiralTurn<1)
                        {
                            spiralTurn++;
                        }
                        else
                        {
                            spiralJump++;
                            spiralTurn = 0;
                        }
                        
                    }
                }
            }
            if (spiralNumber>1000000 || tribunachiFourth>1000000)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(spiralNumber);
            }
        }
    }