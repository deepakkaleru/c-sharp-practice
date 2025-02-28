using System;
example2();
void example2()
{
    string nam = "chinna";
    Console.WriteLine($"Hello {nam.ToUpper()}!");

    List<string> examp1 = ["deepak", "india", "telugu"];
    foreach (var nae in examp1)
    {
        Console.WriteLine($"Hello {nae.ToUpper()}!");
    }
    Console.WriteLine();
    examp1.Add("Mary");
    examp1.Add("Bits");
    examp1.Remove("telugu");
    foreach (var nae in examp1)
    {
        Console.WriteLine($"Hello {nae.ToUpper()}!");
    }
    Console.WriteLine($"My name is {examp1[0]}");
    Console.WriteLine($"I've added {examp1[2]} and {examp1[3]} to the list");
    Console.WriteLine(examp1.Count);
    var index = examp1.IndexOf("deepak");
    if (index == -1)
    {
        Console.WriteLine($"When an item is not found, IndexOf returns {index}");
    }
    else
    {
        Console.WriteLine($"The name {examp1[index]} is at index {index}");
    }
    index = examp1.IndexOf("Not Found");
    if (index == -1)
    {
        Console.WriteLine($"When an item is not found, IndexOf returns {index}");
    }
    else
    {
        Console.WriteLine($"The name {examp1[index]} is at index {index}");
    }
}