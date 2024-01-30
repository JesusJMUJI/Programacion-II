using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Programa
    {

        public class Carton
        {
            public int[,] NumerosCarton;
            public Carton()
            {
                NumerosCarton = new int[4, 4];
                Random rnd = new Random();
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        NumerosCarton[i, j] = rnd.Next(1, 100);
                    }
                }
            }

            public void NumeroEnBingo(int numero)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (NumerosCarton[i,j] == numero)
                        {
                            NumerosCarton[i, j] = NumerosCarton[i, j] * -1;
                        }
                    }
                }
            }

            public virtual double HayPremio()
            {
                List<int> list;
                for (int i = 0; i < 4; i++)
                {
                    list = new List<int>();
                    
                    for (int j = 0; j < 4; j++)
                    {
                        list.Append(NumerosCarton[i, j]);
                    }

                    foreach (int element in list)
                    {
                        bool premio;
                        if (element > 0)
                        {
                            premio = false;
                            return 0;
                        }
                        else
                        { 
                            premio = true; 
                            return 20.5;
                        }
                    }
                }
                return -1;
            }
        }

        public class CartonEspecial : Carton
        {
            bool premio;
            public override double HayPremio() 
            {
                List<int> list;
                for (int i = 0; i < 4; i++)
                {
                    list = new List<int>();

                    for (int j = 0; j < 4; j++)
                    {
                        list.Append(NumerosCarton[i, j]);
                    }

                    foreach (int element in list)
                    {
                        if (element > 0)
                        {
                            premio = false;
                            return 0;
                        }
                        else
                        {
                            premio = true;
                        }
                    }

                    if (premio)
                    {
                        int resultado = 0;
                        foreach (int element in list)
                        {
                            resultado = resultado + element;
                        }
                        
                        if (resultado > 0)
                        {
                            resultado = resultado * -1;
                        }
                        return resultado / 15;
                    }
                }
                return -1;
            }
        }

        public class Jugador
        {
            string nombre;
            double capital = 50;
            List<Carton> listaCartones;

            public void AdquirirCarton(string param)
            {
                switch (param)
                {
                    case "Carton":
                        if (capital > 10.5)
                        {
                            capital = capital - 10.5;
                            listaCartones.Append(new Carton());
                        }
                        break;
                    case "CartonEspecial":
                        if (capital > 20)
                        {
                            capital = capital - 20;
                            listaCartones.Append(new CartonEspecial());
                        }
                        break;
                    default:
                        Console.WriteLine("No tienes suficiente capital para un carton");
                        break;
                }
                
            }

            public int Sorteo()
            {
                Random rdn = new Random();
                int numero = rdn.Next(1, 100);
                return numero;
            }
            
            public void ActualizarCarton(int numSorteo,int contador = 0)
            {
                if (numSorteo != 0)
                {
                    numSorteo = Sorteo();
                }
                listaCartones[contador].NumeroEnBingo(numSorteo);
                double premio = listaCartones[contador].HayPremio();
                if (premio > 0)
                {
                    capital = capital + premio;
                }
                else
                {
                    contador++;
                    if (contador < 3)
                    {
                        ActualizarCarton(numSorteo, contador);
                    }
                }
            }

        }
    }
}
