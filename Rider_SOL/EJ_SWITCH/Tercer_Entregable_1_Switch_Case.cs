using System;

class SwitchTest
{
    static void Main()
    {
        Console.WriteLine("Say a country's name and i'll tell you what language is spoken");

        string wordInput = Console.ReadLine();

        switch (wordInput)
        {
            case "Germany":
                Console.WriteLine($"In {wordInput}, the language 'German' is spoken");
                break;
            case "Austria":
                Console.WriteLine($"In {wordInput}, the language 'German' is spoken");
                break;
            case "Switzerland":
                Console.WriteLine($"In {wordInput}, the language 'German' is spoken");
                break;
            case "United Kingdom":
                Console.WriteLine($"In {wordInput}, the language 'English' is spoken");
                break;
            case "USA":
                Console.WriteLine($"In {wordInput}, the language 'English' is spoken");
                break;
            case "Argentina":
                Console.WriteLine($"In {wordInput}, the language 'Spanish' is spoken");
                break;
            case "Cuba":
                Console.WriteLine($"In {wordInput}, the language 'Spanish' is spoken");
                break;
            case "Venezuela":
                Console.WriteLine($"In {wordInput}, the language 'Spanish' is spoken");
                break;
            default:
                Console.WriteLine("Option not valid, the input is case sensitive or the country is not in the list");
                break;
        }

        Console.ReadKey();
    }
}