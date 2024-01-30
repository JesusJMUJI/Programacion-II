namespace Tercer_Entregable_2;

class SumaDivisores
{
    static void Main()
    {
        int number;
        int sum = 0;
        int i = 1;
    
        Console.Write("Write a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        do
        {
            if (number % i == 0)
            {
                sum += i;
            }

            i++;
        } while (i <= number);
    
        Console.WriteLine($"The sum of the divisors of {number} is {sum}");
        Console.ReadKey();
    }
}