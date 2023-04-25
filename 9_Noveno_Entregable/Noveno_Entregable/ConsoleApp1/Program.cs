using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public Object DameProximo(ArrayList arrayList, Object objeto)
        {
            if (!arrayList.Contains(objeto)) return null;
            int aux = arrayList.IndexOf(objeto);

            if (aux > 0) return arrayList[aux - 1];
            if (arrayList.Count > 1) return arrayList[aux + 1];
            return arrayList[aux];
        }


    }

    public class Cancion : IComparable<Cancion> 
    {
        public string Artista { get; }
        public string Titulo { get; }
        public int Reproducciones { get; set; }

        public Cancion(string artista, string titulo)
        {
            Artista = artista; Titulo = titulo;
        }

        public int CompareTo(Cancion c)
        {
            if (Reproducciones == c.Reproducciones) return 0;

            if (Reproducciones > c.Reproducciones) return 1;

            return -1;

        }
    }


}
