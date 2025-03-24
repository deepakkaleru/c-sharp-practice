using System;

namespace MyApplication
{
    class Car
    {
        string model;
        string color;
        int year;

        static void Main(string[] args)
        {
            Car Ford = new Car();
            Ford.model = "accent";
            Ford.color = "red";
            Ford.year = 1999;

            Car maruti = new Car();
            maruti.model = "nexa";
            maruti.color = "white";
            maruti.year = 2015;

            Console.WriteLine(Ford.model);
            Console.WriteLine(maruti.model);
        }
    }
}
