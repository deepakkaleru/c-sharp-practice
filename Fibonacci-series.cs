using System;
class Program
{
  static void Main()
    {
        int n = 25;
        int[] fibonacciSeries = new int[n];
        fibonacciSeries[0] = 0;
        fibonacciSeries[1] = 1;
        for (int i = 2; i < n; i++)
        {
            fibonacciSeries[i] = fibonacciSeries[i - 1] + fibonacciSeries[i - 2];
        }
        Console.WriteLine("Fibonacci Series:");
        foreach (int num in fibonacciSeries)
        {
            Console.Write(num +"    ");
        }
    }
}

