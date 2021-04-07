using System;

namespace ControlFlowExamples
{
    class Program
    {
        static void Main (string[] args)
        {


            //Console.WriteLine("Enter a number:");
            //var value = Console.ReadLine();
            //if(int.Parse(value) >-1 && int.Parse(value) < 11)
            //{
            //    Console.WriteLine("Valid");
            //    Console.WriteLine(value);
            //}
            //else { Console.WriteLine("Invalid"); }

            //Console.Write("Value 1: ");
            //var value1 = Console.ReadLine();
            //Console.Write("Value 2: ");
            //var value2 = Console.ReadLine();
            //var value3 = Math.Max(int.Parse(value1), int.Parse(value2));
            //Console.WriteLine((value3));
            //int count = 0;
            //for(int i = 0; i < 100; i++)
            //{
            //    if(i%3 == 0) { count++; }
            //}
            //Console.WriteLine(count);
            //while (true)
            //{
            //    var value = Console.ReadLine();
            //    if (value == "ok")
            //    {
            //        break;
            //    }
            //    Console.WriteLine(factorial(int.Parse(value)));
            //}

            //var values = Console.ReadLine();
            //Console.WriteLine(splitter(values));

            int[] red = new int[3] { 155, 222, 195 };
            int[] green = new int[3] { 1, 95, 0 };
            int[] blue = new int[3] { 100, 99, 25 };
            int[][] rgb = { red, green, blue };
            Console.WriteLine(rgb);
            for (int i = 0; i < red.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Red");
                }
                else if (i == 1)
                {
                    Console.WriteLine("Green");
                }
                else if (i == 2)
                {
                    Console.WriteLine("Green");

                }
                for (int j = 0; j < red.Length; j++)
                {
                    Console.WriteLine(rgb[i][j]);
                }
               

            }









        }

        public static int factorial (int value)
        {
            if (value == 1)
            {
                return 1;
            }
            else
            {
                return value * factorial(value - 1);
            }
        }

        public static int splitter (string value)
        {
            string[] val = value.Split(",");
            int max = int.MinValue;
            foreach (string s in val)
            {
                if (int.Parse(s) > max)
                {
                    max = int.Parse(s);
                }
            }
            return max;
        }
    }

}
