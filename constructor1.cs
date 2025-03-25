using System;

class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    //  constructor 1
    public Car()
    {
        Make = "Unknown";
        Model = "Unknown";
        Year = 0;
    }

    // constructor 2
    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Car Details: {Make} {Model}, Year {Year}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // constructor 1
        Car defaultCar = new Car();
        defaultCar.DisplayDetails();

        //  constructor 2
        Car myCar = new Car("Toyota", "hicross", 2023);
        myCar.DisplayDetails();
    }
}
