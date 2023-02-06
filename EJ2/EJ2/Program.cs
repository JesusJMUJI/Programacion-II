using System;


class EJ2{

    static void Main(string[] args) 
    {

        Console.WriteLine("Write three numbers and the biggest one will be shown: ");
        

        int name1 = Convert.ToInt32(Console.ReadLine());
        int name2 = Convert.ToInt32(Console.ReadLine());
        int name3 = Convert.ToInt32(Console.ReadLine());

        int largestNumber = name1;
        if (name2 > largestNumber)
        {
            largestNumber = name2;
        }
        if (name3 > largestNumber)
        {
            largestNumber = name3;
        }
	 
        Console.WriteLine("The biggest number is: " + largestNumber);
    }
}