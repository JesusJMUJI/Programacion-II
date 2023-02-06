using System;

class Programa
{
    static void Main(string arg)
    {
        Console.WriteLine("EScribe tres nombres: ");


        int name1 = Convert.ToInt32(Console.ReadLine());
        int name2 = Convert.ToInt32(Console.ReadLine());
        int name3 = Convert.ToInt32(Console.ReadLine());

        int largestNumber = name1;

        if (largestNumber > name2)
        {
            largestNumber = name2;
        }

        if (largestNumber > name3)
        {
            largestNumber = name3;
        }
    }
}