// find the sum of all integers 1 through 20 that are divisible by 3.
using System;
class divisibleBy3
{
    static void Main()
    {
        int sum = 0;
        for (int i = 1; i <= 20; i++)
        {
            if (i % 3 == 0)
            {
                sum += i;
            }
        }
        Console.WriteLine("The sum of all integers from 1 to 20 that are divisible by 3 is: " + sum);
    }
}