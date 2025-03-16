// Interface example
public interface IAnimal
{
    void Speak();
    void Eat();
}


public class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Bark!");
    }

    public void Eat()
    {
        Console.WriteLine("Eating dog food.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IAnimal myDog = new Dog();
        myDog.Speak();
        myDog.Eat();   
    }
}
