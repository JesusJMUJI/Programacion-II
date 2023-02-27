using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quito_Entregable_1
{
    internal class ArrayBurbuja
    {
        static void Main(string[] args)
        {
            int[] lista = { 10, 5, 2, 12, 18, 23, 41, 42 };
            Burbuja(lista);
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine(lista[i]);
            }
        }

        public static void Burbuja(int[] listaParam)
        {
            int longitudArray = listaParam.GetLength(0);
            bool esBurbuja;

            do
            {
                esBurbuja = false;
                for (int i = 1; i < longitudArray; i++)
                {
                    if (listaParam[i - 1] > listaParam[i])
                    {
                        // Swap listaParam[i-1] and listaParam[i]
                        int temp = listaParam[i - 1];
                        listaParam[i - 1] = listaParam[i];
                        listaParam[i] = temp;
                        esBurbuja = true;
                    }
                }
                longitudArray--;

            } while (esBurbuja);
        }
    }
}
