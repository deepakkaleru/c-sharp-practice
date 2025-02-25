
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("welcome");
            Console.WriteLine("welcome to the world of c#");
            Console.WriteLine(3 * 3);
            string name = "John";
            int myNum = 15;
            Console.WriteLine("Hello" + name);
            Console.WriteLine(myNum);
            string Firstname = "Deepak";
            string Lastname = "Kaleru";
            string Myname = Firstname + Lastname;
            Console.WriteLine(Myname);
            int myInt = 9;
            double myDouble = myInt;  // Automatic casting: int to double

            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);
            Console.WriteLine("Enter username:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);
            // Specify the data source.
            int[] scores = [97, 92, 81, 60];

            // Define the query expression.
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            
            foreach (var i in scoreQuery)
            {
                Console.Write(i + " ");
            }

            
        }
    }
}