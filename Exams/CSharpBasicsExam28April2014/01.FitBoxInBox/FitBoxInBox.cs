using System;

class FitBoxInBox
    {
    static void Main()
        {
        int firstBoxX = int.Parse(Console.ReadLine());
        int firstBoxY = int.Parse(Console.ReadLine());
        int firstBoxZ = int.Parse(Console.ReadLine());
        int secondBoxX = int.Parse(Console.ReadLine());
        int secondBoxY = int.Parse(Console.ReadLine());
        int secondBoxZ = int.Parse(Console.ReadLine());
        if ((firstBoxX+firstBoxY+firstBoxZ)>(secondBoxX+secondBoxY+secondBoxZ))
            {
                int[] smallerBox = new int[3] {secondBoxX, secondBoxY,secondBoxZ };
                int[] biggerBox = new int[3] { firstBoxX, firstBoxY, firstBoxZ };
                FitBoxInBoxTest(smallerBox, biggerBox);
            }
        else if ((firstBoxX+firstBoxY+firstBoxZ)<(secondBoxX+secondBoxY+secondBoxZ))
            {
                int[] biggerBox = new int[3] { secondBoxX, secondBoxY, secondBoxZ };
                int[] smallerBox = new int[3] { firstBoxX, firstBoxY, firstBoxZ };
                FitBoxInBoxTest(smallerBox, biggerBox);
            }
        }

    private static void FitBoxInBoxTest(int[] smallerBox, int[] biggerBox)
        {
        if (smallerBox[0] < biggerBox[0] && smallerBox[1] < biggerBox[1] && smallerBox[2] < biggerBox[2])
            {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", smallerBox[0], smallerBox[1], smallerBox[2], biggerBox[0], biggerBox[1], biggerBox[2]);
            }
        if (smallerBox[0] < biggerBox[0] && smallerBox[1] < biggerBox[2] && smallerBox[2] < biggerBox[1])
            {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", smallerBox[0], smallerBox[1], smallerBox[2], biggerBox[0], biggerBox[2], biggerBox[1]);
            }
        if (smallerBox[0] < biggerBox[1] && smallerBox[1] < biggerBox[2] && smallerBox[2] < biggerBox[0])
            {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", smallerBox[0], smallerBox[1], smallerBox[2], biggerBox[1], biggerBox[2], biggerBox[0]);
            }
        if (smallerBox[0] < biggerBox[1] && smallerBox[1] < biggerBox[0] && smallerBox[2] < biggerBox[2])
            {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", smallerBox[0], smallerBox[1], smallerBox[2], biggerBox[1], biggerBox[0], biggerBox[2]);
            }
        if (smallerBox[0] < biggerBox[2] && smallerBox[1] < biggerBox[1] && smallerBox[2] < biggerBox[0])
            {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", smallerBox[0], smallerBox[1], smallerBox[2], biggerBox[2], biggerBox[1], biggerBox[0]);
            }
        if (smallerBox[0] < biggerBox[2] && smallerBox[1] < biggerBox[0] && smallerBox[2] < biggerBox[1])
            {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", smallerBox[0], smallerBox[1], smallerBox[2], biggerBox[2], biggerBox[0], biggerBox[1]);
            }
        }
    }