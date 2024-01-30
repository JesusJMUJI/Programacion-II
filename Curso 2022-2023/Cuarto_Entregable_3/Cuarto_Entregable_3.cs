class Entregable_3
{
    static void Main()
    {
        Console.Write("Escribe la fila que quieres poner a 0:");
        int filaConcreta = Convert.ToInt32(Console.ReadLine());
        filaConcreta --;

        int[,] matriz =
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        MatrizAsignar0(matriz, filaConcreta);

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }

    public static void MatrizAsignar0(int[,] matriz, int fila0)
    { 

        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            matriz[fila0, j] = 0;
        }
    }
}