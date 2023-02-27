using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quinto_Entregable_2
{
    internal class BúsquedaLineal
    {
        static void Main(string[] args)
        {
            int[] testArray = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3 };
            int index = BusquedaLineal(testArray, 4);

            Console.WriteLine(index);
        }

        public static int BusquedaLineal(int[] array, int index)
        {
            for (int i = 0; i < array.Length; i++) 
            { 
                if (array[i] == index)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
