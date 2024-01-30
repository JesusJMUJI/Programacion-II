using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    internal class OgrosYBrujas
    {
        public class Carta
        {
            private int _Valor { get; set; }
            private string _Palo { get; set; }

            public Carta(int valor, string palo)
            {
                _Valor = valor;
                _Palo = palo;
            }

            public string MostrarCarta() 
            {
                string cartaReturn = Convert.ToString($"{_Valor} de {_Palo}");
                return cartaReturn;
            }
            
        }

        public class Baraja
        {
            public Carta[] arrayCartas;
            private int siguienteCarta = 0;
            private int maxCartas;

            public Baraja()
            {
                maxCartas = arrayCartas.Length;
                arrayCartas = new Carta[maxCartas];

                // Crear orco
                for (int i = 0; i < (maxCartas / 2); i++)
                {
                    arrayCartas[i] = new Carta(i, "Orco");
                }

                // Crear bruja
                for (int i = (maxCartas / 2) + 1; i < (maxCartas / 2); i++)
                {
                    arrayCartas[i] = new Carta(i, "Bruja");
                }

                // Barajar baraja
                Random random = new Random();
                for (int j = 0; j < maxCartas; j++)
                {
                    int k = random.Next(arrayCartas.Length);
                    Carta temp = arrayCartas[j];
                    arrayCartas[j] = arrayCartas[k];
                    arrayCartas[k] = temp;
                }
            }

            public Carta CogeCarta()
            {
                siguienteCarta++;
                return arrayCartas[siguienteCarta];
            }
        }

        public class Jugador
        {
            private Carta[] cartasJugador;
            public int puntuacion { get; private set; }

            public void JuegaCarta()
            {

            }

            public int DevolverNumeroCartas()
            {
                return cartasJugador.Length;
            }

            //Otro metodo de return varibale privada sin metodo
            //public int numeroCartas { get { return cartasJugador} }
        }

        public class Partida
        {
            Jugador jugador1 = new Jugador();
            Jugador jugador2 = new Jugador();

            public void JuegaPartida()
            {

                while (jugador1.DevolverNumeroCartas() > 0 || jugador2.DevolverNumeroCartas() > 0)
                {
                    
                }

            }
        }
    }
}

/*La clase Partida debe instanciar un objeto Baraja y dos objetos Jugador. 
 * 
 * También proporcionará un método JuegaPartida() que solicitará a ambos jugadores, en cada ronda, una carta, comparará ambas cartas de acuerdo al criterio del juego indicado anteriormente y acumulará 1 punto más al jugador que haya ganado esa ronda. 
 * 
 * Este proceso se repite para todas las rondas posibles. 
 * 
 * Finalmente, este método deberá devolver una cadena que indique cuál ha sido el resultado final de la partida.*/
