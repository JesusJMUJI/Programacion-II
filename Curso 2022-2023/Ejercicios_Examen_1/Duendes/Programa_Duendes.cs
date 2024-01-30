using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duendes
{
    internal class Programa_Duendes
    {
        public class CampoDeJuego
        {
            private decimal XMax = 0;
            private decimal YMax = 0;

            public CampoDeJuego(decimal xMax, decimal yMax)
            {
                XMax = xMax;
                YMax = yMax;
            }
        }

        public class Duendecillo
        {
            private decimal CoordX { get; set; }
            private decimal CoordY { get; set; }
            protected int NivelEnergía { get; set; }
            private CampoDeJuego CampoCompleto { get; set; }

            public virtual string Actuar()
            {
                return "";
            }

            public void Moverse()
            {
                Random r = new Random();
                decimal rInt = r.Next(-3,3);

                CoordX += rInt;
                CoordY += rInt;

                NivelEnergía--;
            }

            public class Tesoro
            {
                // No completar
            }
        }

        public class Revoltoso : Duendecillo
        {

            public override string Actuar()
            {
                string[] listaFrases = { "ji, ji", "¡ahuuu!", };

                Random aleatorio = new Random();
                int r = aleatorio.Next(0, 2);

                string randomString = listaFrases[r];

                if (NivelEnergía > 0)
                {
                    return "";
                }
                else
                {
                    return randomString;
                }
            }
        }

        public class Coleccionista : Duendecillo
        {
            Tesoro[] listaTesoro = new Tesoro[] { };

            public void Añadir()
            {
                // No completar
            }

            public override string Actuar() 
            {
                Random r = new Random();
                int r = r.Next(0, );
            }
        }
    }
}
