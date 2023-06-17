zusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entregable
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public class Enemigo
        {
            public enum Armas
            {
                Cuchillo, Espada, Hacha
            }
            private int Tvida;

            public virtual int Golpear(Armas armaUsada)
            {
                switch (armaUsada)
                {
                    case Armas.Cuchillo:
                        return 3;
                    case Armas.Espada:
                        return 5;
                    case Armas.Hacha:
                        return 10;
                    default:
                        return 0;
                }
            }
        }

        public class Malvado : Enemigo
        {
            public override int Golpear(Armas armaUsada)
            {
                switch (armaUsada)
                {
                    case Armas.Cuchillo:
                        return 6;
                    case Armas.Espada:
                        return 10;
                    case Armas.Hacha:
                        return 20;
                    default:
                        return 0;
                }
            }
        }


        public class Diabólico : Malvado
        {
            public string LanzarHechizo()
            {
                string[] arrayHechizos = new string[]
                    { "conjuro de serpientes", "cnjuro del averno", "conjuro inofensivo" };
                Random rnd = new Random();
                int hechizoRandom = rnd.Next(arrayHechizos.Length);
                return arrayHechizos[hechizoRandom];
            }
        }
    

        public void Lucha(List<Enemigo> listaEnemigos)
        {
            for (int i = 0; i < listaEnemigos.Count; i++)
            {
                Stack<string> stackHechizos = new Stack<string>();

                if (listaEnemigos[i].GetType() == typeof(Diabólico))
                {
                    Diabólico d = listaEnemigos[i] as Diabólico;
                    stackHechizos.Push(d.LanzarHechizo());
                }

                if (listaEnemigos[i].GetType() ==  typeof(Enemigo))
                {
                    listaEnemigos.RemoveAt(i);
                    i--;
                }
                
            }
        }

        public class MalvadoComparer : IComparer<Malvado>
        {
            public int Compare(Malvado a, Malvado b)
            {
                if (a.Golpear(Enemigo.Armas.Espada) > b.Golpear(Enemigo.Armas.Espada))
                {
                    return 1;
                }
                else if (a.Golpear(Enemigo.Armas.Espada) < b.Golpear(Enemigo.Armas.Espada))
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
    
}
