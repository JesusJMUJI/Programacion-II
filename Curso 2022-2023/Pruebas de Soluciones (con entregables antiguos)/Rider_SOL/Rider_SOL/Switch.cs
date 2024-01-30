using System;

class SwitchTest
{
    static void Main()
    {
        Console.WriteLine("Say a country's name and i'll tell you what language is spoken");

        string word = Console.ReadLine();

        switch (word)
        {
            case "Germany":
                Console.WriteLine($"In {word}, the language 'German' is spoken");
                    break;
            case "Austria":
                Console.WriteLine($"In ");
                    break;

        }
    }
}