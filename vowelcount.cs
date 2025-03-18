using System;

class VowelCount
{
    static int CountVowels(string input)
    {
        int count = 0;
        foreach (char c in input.ToLower())
        {
            if ("aeiou".Contains(c)) // Check if the character is a vowel
            {
                count++;
            }
        }
        return count;
    }

    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        int vowelCount = CountVowels(input);
        Console.WriteLine($"Number of vowels: {vowelCount}");
    }
}

