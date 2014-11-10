using System;
using System.Numerics;

    class BitShooter
    {
        static void Main()
        {
            ulong n = ulong.Parse(Console.ReadLine()); ;
            int leftSide = 0;
            int rightSide = 0;

            for (int i = 0; i < 3; i++)
            {
                ulong mask = 0;
                string values = Console.ReadLine();
                string[] tokens = values.Split(' ');
                int[] shoot = Array.ConvertAll<string, int>(tokens, int.Parse);

                for (int j = 0; j < shoot[1]; j++)
                {
                    mask = mask << 1;
                    mask = mask | 1;
                }
                if (shoot[0]-(shoot[1]/2)<0)
                {
                    mask = mask >> (shoot[1]/2) - shoot[0];
                }
                else if (shoot[0] - (shoot[1] / 2) > 0)
                {
                    mask = mask << shoot[0] - (shoot[1]/2);
                }
                n = n & ~mask;
            }
            for (int i = 0; i < 64; i++)
            {
                n = n >> 1;
                if ((n & 1) == 1 && i < 31)
                {
                    rightSide += 1;
                }
                else if ((n & 1) == 1 && i > 30)
                {
                    leftSide += 1;
                }
            }
            Console.WriteLine("left: {0}",leftSide);
            Console.WriteLine("right: {0}", rightSide);
        }
    }

//using System;

//class BitShooter
//{
//    static void Main()
//    {
//        const int BITS = 64;

//        ulong inputBits = ulong.Parse(Console.ReadLine());
//        ulong shootedBits = 0;
//        for (int i = 0; i < 3; i++)
//        {
//            string shoot = Console.ReadLine();
//            string[] shootDetails = shoot.Split(' ');
//            int shootCenter = int.Parse(shootDetails[0]);
//            int shootSize = int.Parse(shootDetails[1]);
//            int startBit = shootCenter - shootSize / 2;
//            int endBit = shootCenter + shootSize / 2;
//            for (int bit = startBit; bit <= endBit; bit++)
//            {
//                if (bit >= 0 && bit < BITS)
//                {
//                    shootedBits = shootedBits | ((ulong)1 << bit);
//                }
//            }
//        }
        
//        ulong aliveBits = inputBits & (~shootedBits);
        
//        //Console.WriteLine(Convert.ToString((long)inputBits, 2).PadLeft(64,'0'));
//        //Console.WriteLine(Convert.ToString((long)~shootedBits, 2).PadLeft(64, '0'));
//        //Console.WriteLine(Convert.ToString((long)aliveBits, 2).PadLeft(64, '0'));

//        ulong rightBits = 0;
//        for (int i = 0; i < BITS / 2; i++)
//        {
//            rightBits += aliveBits & 1;
//            aliveBits >>= 1;
//        }

//        ulong leftBits = 0;
//        for (int i = 0; i < BITS / 2; i++)
//        {
//            leftBits += aliveBits & 1;
//            aliveBits >>= 1;
//        }

//        Console.WriteLine("left: " + leftBits);
//        Console.WriteLine("right: " + rightBits);
//    }
//}
