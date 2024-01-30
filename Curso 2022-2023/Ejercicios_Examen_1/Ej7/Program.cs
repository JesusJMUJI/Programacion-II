using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej7
{
    internal class Program
    {
        public static void Main() 
        {
            char[] chars = { 'a', 'b', 'c', 'd' ,'e' ,'f' };
            InvertedArray(chars);

            foreach (var item in chars)
            {
                Console.Write($"{item}");
            }
        }
        public static void InvertedArray(char[] chars, int counter = 0)
        {
            if (counter > (int)(chars.Length / 2))
            {

            }
            else
            {
                char aux;
                aux = chars[counter];
                chars[counter] = chars[chars.Length - counter - 1];
                chars[chars.Length - counter - 1] = aux;

                InvertedArray(chars, counter + 1);
            }

            // Otro método

        /*  if (counter <= (int)(chars.Length / 2))
            {
                char aux;
                aux = chars[counter];
                chars[counter] = chars[chars.Length - counter - 1];
                chars[chars.Length - counter - 1] = aux;

                InvertedArray(chars, counter + 1);
            }
        */
        }
    }
}

// Escribir un método recursivo que devuelva el array invertido de un array de entrada de tipo char.
// Write a recursive method that returns the inverted array of an input array of type char.

// ['a', 'c', 'c']