using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Person person = new Person("Deekshith", 25);

       
        person.Greet();
    }
}