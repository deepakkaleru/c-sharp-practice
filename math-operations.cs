using System;

//namespace integerfloat
//{
//class Program
//{
//static void Main(string[] args)
integerprsctice();
void integerprsctice()
{
    int a = 18;
    int b = 6;
    int c = a + b;
    int d = a - c;
    int e = a * c;
    int f = a / b;
    int g = a * b - c * d / f;
    Console.WriteLine(c);

    Console.WriteLine(d);

    Console.WriteLine(e);

    Console.WriteLine(f);
    Console.WriteLine(g);
    int x = 7;
    int y = 4;
    int z = 3;
    int m = (x + y) / z;
    int n = (x + y) % z;
    Console.WriteLine($"quotient: {m}");
    Console.WriteLine($"remainder: {n}");
    int max = int.MaxValue;
    int min = int.MinValue;
    Console.WriteLine($"The range of integers is {min} to {max}");

}



doublepractice();
void doublepractice()
{ 
    double i = 5;
    double j = 4;
    double k = 2;
    double l = (i + j) / k;
    Console.WriteLine(l);
    double mx = double.MaxValue;
    double mn = double.MinValue;
    Console.WriteLine($"The range of double is {mn} to {mx}");
    Console.WriteLine($"{mn} {mx}");
    double third = 1.0 / 3.0;
    Console.WriteLine(third);
}

Areaofthecirclepractice();
void Areaofthecirclepractice()
{
    double radius = 2.50;
    double area = Math.PI * radius * radius;
    Console.WriteLine($"Area of the circle is: {area}");
}