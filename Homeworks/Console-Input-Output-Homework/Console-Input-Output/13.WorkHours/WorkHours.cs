using System;

    class WorkHours
    {
        static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            double daysAviable = d - (d*0.1);
            double workHours = (daysAviable * 12 * (p/100));
            workHours = Math.Floor(workHours);

            if (workHours >= h)
            {
                Console.WriteLine("Yes");
                Console.WriteLine(workHours-h);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine(workHours - h);
            }

        }
    }