using System;

class FriendBits
    {
    static void Main()
        {
        uint n = uint.Parse(Console.ReadLine()); ;
        //Console.WriteLine(Convert.ToString(n,2));
        uint previousNumber = 0;
        uint count = 0;
        uint friendBits = 0;
        uint aloneBits = 0;

        for (int i = 31; i > -2; i--)
            {
            uint tempNumber = ((n>>i)&1);
            if (i == 31)
                {
                previousNumber = tempNumber;
                count = 1;
                }
            else if (tempNumber != previousNumber || i == -1)
                {
                if (count == 1)
                    {
                    aloneBits = (aloneBits<<1)|previousNumber;
                    //Console.WriteLine(Convert.ToString(aloneBits,2));
                    }
                else
                    {
                    for (int j = 0; j < count; j++)
                        {
                        friendBits = (friendBits << 1) | previousNumber;
                        //Console.WriteLine(Convert.ToString(friendBits, 2));
                        }
                    count = 1;
                    }
                previousNumber = tempNumber;
                }
            else if (tempNumber == previousNumber)
                {
                count++;
                }
            }
        Console.WriteLine(friendBits);
        Console.WriteLine(aloneBits);
        }
    }