using System;

class Program 
{ 
    static void Main(string[] args)
    {
        Console.WriteLine("Hola, me dices tu nombre: ");
        string name = Console.ReadLine();
        if (name == "Raul")
        {
            Console.WriteLine(name + " " + "guapo");
        }
        else if (name == "Alonso")
        {
            Console.WriteLine(name + " " + "buen dm :), dale agro a ");
        }
        else 
        {
            Console.WriteLine("Bienvenido a C#, " + name);
        }
        
        Console.ReadKey();
    }
}