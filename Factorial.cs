using System;

class FactorialProgram
{
    static int Factorial(int num)
    {
        if (num == 0 || num == 1) return 1;
        return num * Factorial(num - 1);
    }
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number =int.Parse(Console.ReadLine()); 

        if (number < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
        }
        else
        {
            int result = Factorial(number);
            Console.WriteLine($"Factorial of {number} is {result}");
        }
    }

   
}

