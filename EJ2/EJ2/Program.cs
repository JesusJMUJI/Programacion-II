using System;

class Ej2{

    static void Main(string[] args) {
        
        Console.WriteLine("Write three numbers and the biggest one will be shown: ");
        

        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());
        int number3 = Convert.ToInt32(Console.ReadLine());

        int largestNumber = number1;
        if (number2 > largestNumber)
        {
            largestNumber = number2;
        }
        if (number3 > largestNumber)
        {
            largestNumber = number3;
        }
	 
        Console.WriteLine("The biggest number is: " + largestNumber);
    }
}