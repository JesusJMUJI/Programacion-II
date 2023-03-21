using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septimo_Entregable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Enemigo odioso = new Enemigo("Odioso",
                             "Espada");
            Enemigo brujo = odioso;
            brujo.SetNombre("Brujo");
            brujo.SetArma(“Hechizos");
            Console.WriteLine(odioso.GetLucha());
            Console.WriteLine(brujo.GetLucha());

        }
        public struct Enemigo
        {
            private String nombre;
            private String arma;
            public Enemigo(String nombre, String arma)
            {
                this.nombre = nombre;
                this.arma = arma;
            }
            public String Lucha()
            {
                return "Me llamo “+nombre+“ y ataco con “+arma;
            }
            public String GetNombre() { return nombre; }
            public String GetArma() { return nombre; }
            public void SetNombre(String n) { nombre = n; }
            public void SetArma(String a) { arma = a; }

        }
        public class Villano
        {
            /// El mismo contenido que el struct Enemigo,
            ///   es decir, los atributos nombre y arma, el 
            ///   constructor y los métodos públicos Lucha, 
            ///   GetNombre, GetArma, SetNombre y SetArma.
        }

    }
}
