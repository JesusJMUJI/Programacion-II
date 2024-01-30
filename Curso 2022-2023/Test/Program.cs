class Programa
{
    public void Selcccion(int[] v)
    {
        int[,] ints;
        for (int i = 0; i < v.Length - 1; i++)
        {
            int posicion = i;
            for (int j = i++; j < v.Length; j++ )
            {
                if (v[j] < v[posicion]) posicion = j;
            }
            int aux = v[i];
            v[i] = v[posicion];
            v[posicion] = aux;
        }
    }
}
