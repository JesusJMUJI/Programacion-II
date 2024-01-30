using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_Random
{
    internal class Program
    {
        public class Coche
        {
            private int ID { get; set; }
            private string Marca { get; set; }
            private string Modelo { get; set; }
            private string KM { get; set; }
            private decimal Precio { get; set; }

            public string ToString()
            {
                return ($"Marca de coche {Marca}, {Modelo}, {Precio}");
            }
        }

        public class Concesionario
        {
            private Coche[] ListaCoches { get; set; }
            private int LimiteCoches { get; set; }

        }
    }
}
