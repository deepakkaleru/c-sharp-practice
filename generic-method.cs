public class GenericMethods
{
    public void Display<T>(T value)
    {
        Console.WriteLine($"Value: {value}, Type: {typeof(T)}");
    }
}
class Program
{
    static void Main()
    {
        GenericMethods gm = new GenericMethods();
        gm.Display(123);     
        gm.Display("Hello");   
        gm.Display(3.14);      
    }
}
