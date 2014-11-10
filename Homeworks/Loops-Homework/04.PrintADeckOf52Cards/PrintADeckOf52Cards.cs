using System;

class PrintADeckOf52Cards
{
    static void Main()
    {
        char[] color = new char [ 4 ]{'♣', '♦', '♥', '♠'};
        for (int i = 2; i < 15; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                switch (i)
                {
                    case 2: Console.Write("{0}{1}",i, color[j]); break;
                    case 3: Console.Write("{0}{1}", i, color[j]); break;
                    case 4: Console.Write("{0}{1}", i, color[j]); break;
                    case 5: Console.Write("{0}{1}", i, color[j]); break;
                    case 6: Console.Write("{0}{1}", i, color[j]); break;
                    case 7: Console.Write("{0}{1}", i, color[j]); break;
                    case 8: Console.Write("{0}{1}", i, color[j]); break;
                    case 9: Console.Write("{0}{1}", i, color[j]); break;
                    case 10: Console.Write("{0}{1}", i, color[j]); break;
                    case 11: Console.Write("J" + color[j]); break;
                    case 12: Console.Write("Q" + color[j]); break;
                    case 13: Console.Write("K" + color[j]); break;
                    case 14: Console.Write("A" + color[j]); break;
                    default: break;
                }
                if (j<3)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine("");
        }
    }
}