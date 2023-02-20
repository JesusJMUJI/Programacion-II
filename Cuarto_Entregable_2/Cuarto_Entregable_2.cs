class Entregable_2
{
    static void Main()
    {
        double[,] matriz =
        {
            {-5.4, -3.2, -3.1, 2.5, 3.6},
            { 3.2, 4.8, 4.9, 5.2, 6.9},
            {-1.4, -1.2, -1.0, -0.5, -0.1}
        };

        int[] posiciones = ComprobarNegativos(matriz);

        for (int i = 0; i < posiciones.Length; i++)
        {
            Console.WriteLine("Fila {0}: {1}", i, posiciones[i]);
        }

        Console.ReadLine();
        
    }

    public static int[] ComprobarNegativos(double[,] matriz)
    {
        int n = matriz.GetLength(0); //filas
        int m = matriz.GetLength(1); //columna
        int[] resultado = new int[n];

        for (int fila= 0; fila < n; fila++) 
        {
            int soloNegativos = -1;

            for (int columna = 0; columna < m; columna++)
            {
                if (matriz[fila, columna] >= 0)
                {
                    soloNegativos = columna;
                    break;
                }
            }
            resultado[fila] = soloNegativos;
        }
        return resultado;
    }
}