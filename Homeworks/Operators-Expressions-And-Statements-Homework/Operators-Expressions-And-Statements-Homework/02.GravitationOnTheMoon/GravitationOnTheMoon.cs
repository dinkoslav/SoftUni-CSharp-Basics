using System;

    class GravitationOnTheMoon
    {
        static void Main()
        {
            Console.WriteLine("Enter Earth weight : ");
            double weightOnEarth = double.Parse(Console.ReadLine());
            double weightOnMoon = weightOnEarth * 0.17;
            Console.WriteLine(weightOnMoon);
        }
    }
