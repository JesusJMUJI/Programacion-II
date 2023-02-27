using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quinto_Entregable_3
{
    internal class BusquedaLineal
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int index = BusquedaBinaria(myArray, 4);

            Console.WriteLine(index);
        }

        public static int BusquedaBinaria(int[] array, int index)
        {
            int Min = 0; int Max = array.Length;

            while (Min <= Max) 
            { 
                int Mid = (Min + Max) / 2;

                if (array[Mid] == index)
                {
                    return Mid; // Elemento encontrado
                }
                else if (array[Mid] < index) 
                {
                    Min = Mid + 1; // Buscar parte derecha del array
                }
                else 
                {
                    Max = Mid - 1; // Buscar parte izquierda del array
                }

            }
            return -1; // Elemento no econtrado
        }
    }
}
