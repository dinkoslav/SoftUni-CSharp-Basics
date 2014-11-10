using System;

class BitsInverter
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            for (int bit = 7; bit >= 0; bit--)
            {
                index++;
                if ((step == 1) || (index % step == 1))
                {
                    num = num ^ (1 << bit);
                }
            }
            Console.WriteLine(num);
        }
    }
}

// Moe reshenie ..............................
//using System;

//    class BitsInverter
//    {
//        static void Main()
//        {
//            int n = int.Parse(Console.ReadLine());
//            int step = int.Parse(Console.ReadLine());
//            string bitsList = "";

//            for (int i = 0; i < n; i++)
//            {
//                byte number = byte.Parse(Console.ReadLine());
//                string binary = Convert.ToString(number, 2);
//                binary = binary.PadLeft(8, '0');
//                bitsList += binary;
//            }

//            char[] array = bitsList.ToCharArray();
//            for (int i = 0; i < array.Length / step + 1; i++)
//            {
//                char charToChange = array[i * step];
//                if (charToChange == '0')
//                    array[i * step] = '1';
//                else
//                    array[i * step] = '0';
//            }
//            string outputBits = new string(array);

//            for (int i = 0; i < n * 8; i += 8)
//            {
//                string str = outputBits.Substring(i, 8);
//                string DecimalVal = Convert.ToInt32(str, 2).ToString();
//                Console.WriteLine(DecimalVal);
//            }
//        }
//    }
