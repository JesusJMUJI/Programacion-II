class Amigos
{
    int[] number1;
    int[] number2;
    int listaSuma1 = 0;
    int listaSuma2 = 0;

    static void Main()
    {
        NumerosAmigos()
    }

    public void NumerosAmigos()
    {
        for (int i = 0; i < number1.Length; i++)
        {
            listaSuma1 += number1[i];
        }
        for (int i = 0; i < number2.Length; i++)
        {
            listaSuma2 += number2[i];
        }

        if (listaSuma1 - number1 == listaSuma2 && listaSuma2 - number2 == listaSuma1)
        {
            Console.WriteLine("Los números son amigos");
        }
        else
        {
            Console.WriteLine("Los números no son amigos");
        }
    }
}
