class Entregable_1
{

    static void Main()
    {
        Console.Write("Escribe el primer numero:"); int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Escribe el segundo numero"); int num2 = Convert.ToInt32(Console.ReadLine());

        bool sonAmigos = SonAmigos(num1, num2);

        if (sonAmigos)
        {
            Console.WriteLine("{0} y {1} son amigos", num1, num2);
        }
        else
        {
            Console.WriteLine("{0} y {1} no son amigos", num1, num2);
        }

        Console.ReadLine();
    }

    public static bool SonAmigos(int num1, int num2)
    {
        int sum1 = 0;
        int sum2 = 0;
        for (int i = 1; i <= num1 / 2; i++) 
            // Se divide el num1 entre dos para optimizar el bucle,
            // según el ejemplo dado en clase,
            // no pueden haber divisores mayores que la mitad del número
        {
            if (num1 % i == 0)
            {
                sum1 += i;
            }
        }
        for (int i = 1; i <= num2 / 2; i++)
        {
            if (num2 % i == 0)
            {
                sum2 += i;
            }
        }
        return sum1 == num2 && sum2 == num1;
    }
}
