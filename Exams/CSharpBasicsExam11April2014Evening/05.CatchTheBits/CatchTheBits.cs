using System;

    class CatchTheBits
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int position = 0;
            int outputNumber = 0;
            int outputPosition = 0;

            for (int i = 0; i < numbers; i++)
            {
                int n = int.Parse(Console.ReadLine());
                for (int bytes = 0; bytes < 8; bytes++)
                {
                    if (position % step == 1 || (step == 1 && position > 0))
                    {
                        int bit = n >> (7 - bytes) & 1;
                        if (bit == 1)
	                    {
                            outputNumber = (outputNumber << 1 )| 1;
	                    }
                        else
                        {
                            outputNumber = outputNumber << 1;
                        }
                        outputPosition++;
                        if (outputPosition == 8)
                        {
                            Console.WriteLine(outputNumber);
                            outputPosition = 0;
                            outputNumber = 0;
                        }
                    }
                    position++;
                } 
            }
            if (outputPosition > 0)
            {
                outputNumber = outputNumber << 8 - outputPosition;
                Console.WriteLine(outputNumber);
            }
        }
    }
