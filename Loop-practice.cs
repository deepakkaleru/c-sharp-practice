using System;

namespace Looppractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 20;// if else practice
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);
            int day = 4;
            switch (day) //switch practice
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
            }
            int i = 0;
            while (i < 3) //while loop practice
            {
                Console.WriteLine(i);
                i++;
            }
            int k = 9;// do while loop practice
            do
            {
                Console.WriteLine(k);
                k++;
            }
            while (k < 13);
            //for loop
            for (int a = 1; a <= 2; a++)
            {
                Console.WriteLine("Outer: " + a);

                // Inner loop
                for (int b = 1; b <= 3; b++)
                {
                    Console.WriteLine(" Inner: " + b);
                }
            }
        }
    }
}
