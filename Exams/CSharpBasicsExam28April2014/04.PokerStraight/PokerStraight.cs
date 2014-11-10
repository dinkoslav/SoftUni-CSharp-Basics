using System;

class PokerStraight
    {
    static void Main()
        {
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        for (int x1 = 1; x1 < 15; x1++)
            {
            int x2 = x1 + 1;
            int x3 = x2 + 1;
            int x4 = x3 + 1;
            int x5 = x4 + 1;
            for (int y1 = 1; y1 < 5; y1++)
                {
                for (int y2 = 1; y2 < 5; y2++)
                    {
                    for (int y3 = 1; y3 < 5; y3++)
                        {
                        for (int y4 = 1; y4 < 5; y4++)
                            {
                            for (int y5 = 1; y5 < 5; y5++)
                                {
                                if ((10*x1+y1)+(20*x2+y2)+(30*x3+y3)+(40*x4+y4)+(50*x5+y5)==n)
                                    {
                                    count++;
                                    //Console.Write("(");
                                    //PrintCard(x1);
                                    //PrintSuit(y1);
                                    //Console.Write(" ");
                                    //PrintCard(x2);
                                    //PrintSuit(y2);
                                    //Console.Write(" ");
                                    //PrintCard(x3);
                                    //PrintSuit(y3);
                                    //Console.Write(" ");
                                    //PrintCard(x4);
                                    //PrintSuit(y4);
                                    //Console.Write(" ");
                                    //PrintCard(x5);
                                    //PrintSuit(y5);
                                    //Console.Write(")");
                                    //Console.WriteLine();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        Console.WriteLine(count);
        }

    //static void PrintCard(int x)
    //    {
    //    switch (x)
    //        {
    //        case 1: Console.Write("A"); break;
    //        case 2: Console.Write("2"); break;
    //        case 3: Console.Write("3"); break;
    //        case 4: Console.Write("4"); break;
    //        case 5: Console.Write("5"); break;
    //        case 6: Console.Write("6"); break;
    //        case 7: Console.Write("7"); break;
    //        case 8: Console.Write("8"); break;
    //        case 9: Console.Write("9"); break;
    //        case 10: Console.Write("10"); break;
    //        case 11: Console.Write("J"); break;
    //        case 12: Console.Write("Q"); break;
    //        case 13: Console.Write("K"); break;
    //        case 14: Console.Write("A"); break;
    //        };
    //    }
    //static void PrintSuit(int y)
    //    {
    //    switch (y)
    //        {
    //        case 1: Console.Write("C"); break;
    //        case 2: Console.Write("D"); break;
    //        case 3: Console.Write("H"); break;
    //        case 4: Console.Write("S"); break;
    //        };
    //    }
    }
