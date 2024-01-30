using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buenas, me dices tu no nombre...? ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Buenas " + nombre);
            Console.ReadKey();
        }
    }
}
