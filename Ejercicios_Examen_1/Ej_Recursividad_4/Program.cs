using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Ej_Recursividad_4
{
    internal class Program
    {
        static void Main()
        {
            int digito = 273;
            Console.WriteLine(NumDigitos(digito));
            Console.ReadKey();
        }

        public static int NumDigitos(int entero)
        {
            if (entero / 10 == 0)
            {
                return 1;
            }
            else
            {
                return 1 + NumDigitos(entero / 10);
            }
        }
    }
}

/*
 * Escribir un método recursivo para calcular el número de dígitos que tiene un número entero.
*/