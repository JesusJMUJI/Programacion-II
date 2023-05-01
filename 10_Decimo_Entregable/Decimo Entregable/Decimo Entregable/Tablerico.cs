using System;
using System.Collections.Generic;

namespace Decimo_Entregable
{
    internal class Tablerico
    {
        public static void Main(string[] args)
        {
            Tablero tablero = new Tablero();
            tablero.DameFormasMismoColor(Colores.Rojo);
            //tablero.Ordenar();
            //tablero.Reducir(, 10);
        }

        public class Forma : IComparable<Forma>
        {

            private protected int Lado { get; set; }
            public Colores Color { get; set; }

            public Forma(int lado = 0, Colores color = Colores.Rojo)
            {
                Lado = lado;
                Color = color;
            }

            public virtual double Area()
            {
                return Lado;
            }
            
            public int CompareTo(Forma other)
            {
                return Area().CompareTo(other.Area());
            }
            
        }
        
                            
        public enum Colores
        {
            Rojo, Verde, Azul
        }
        
        public class Cuadrado : Forma
        {

            public Cuadrado(int lado, Colores color) : base(lado, color) { }
            
            public override double Area()
            {
                return Lado * Lado;
            }
        }
        
        public class Triangulo : Forma
        {
            
            public Triangulo(int lado, Colores color) : base(lado, color) { }
            
            public override double Area()
            {
                return Lado * Lado / 2.0;
            }
        }
        
        public class Tablero
        {
            private Forma[,] _listaFormas;
            
            public Tablero()
            {
                _listaFormas = new Forma[10, 10];
                
                for (int i = 0; i < _listaFormas.GetLength(0); i++)
                {
                    for (int j = 0; j < _listaFormas.GetLength(1); j++)
                    {
                        Random rnd = new Random();
                        int ladoRandom = rnd.Next(0, 51);
                        Colores colorRandom = (Colores) rnd.Next(0, 3);
                        
                        if (rnd.Next(0, 2) == 0)
                        {
                            _listaFormas[i, j] = new Cuadrado(ladoRandom, colorRandom);
                        }
                        else
                        {
                            _listaFormas[i, j] = new Triangulo(ladoRandom, colorRandom);
                        }
                    }
                }
            }
            
            public List<Colores> DameFormasMismoColor(Colores color)
            {
                List<Colores> ListaColores = new List<Colores>();
                
                for (int i = 0; i < _listaFormas.GetLength(0); i++)
                {
                    for (int j = 0; j < _listaFormas.GetLength(1); j++)
                    {
                        if (_listaFormas[i, j].Color == color)
                        {
                            ListaColores.Add(_listaFormas[i, j].Color);
                        }
                    }
                }
                
                return ListaColores;
            }
            
            public void Ordenar(List<Forma> listaFormasAOrdenar)
            {
                
                for (int i = 0; i < _listaFormas.GetLength(0); i++)
                {
                    for (int j = 0; j < _listaFormas.GetLength(1); j++)
                    {
                        listaFormasAOrdenar.Add(_listaFormas[i, j]);
                    }
                }
                
                listaFormasAOrdenar.Sort();

            }
            
            public void Reducir(List<Forma> listaReducir, int cantidad)
            {
                for (int i = 0; i < _listaFormas.GetLength(0); i++)
                {
                    for (int j = 0; j < _listaFormas.GetLength(1); j++)
                    {
                        if (_listaFormas[i, j].Area() < cantidad)
                        {
                            listaReducir.Remove(_listaFormas[i, j]);
                        }
                    }
                }
            }
        }

    }
}

/*
1.  El tipo enumerado Colores con los valores Rojo, Verde y Azul.

2.  La clase Forma que contenga información sobre su Lado (un entero), Color (del tipo enumerado Colores y un método Área() que devuelve un double representando el valor del área ocupada, por ahora devuelve el valor de Lado.

3.  La clase Cuadrado es una Forma en la que se reescribe el método Área() para que devuelva el área del cuadrado al que representa (recuerda que la fórmula matemática del área de un cuadrado es area=l*l).

4.  La clase Triángulo es una Forma en la que se reescribe el método Área() para que devuelva el área del triángulo al que representa (la fórmula matemática del área de un triángulo a utilizar es area=l*l2).

5.  La clase Tablero contiene un array privado de N filas y N columnas de objetos Forma. En su constructor se han de rellenar todas sus casillas con objetos Cuadrado o Triángulo de forma aleatoria. El método público DameFormasMismoColor devuelve una lista con todos los objetos del array que son del mismo color que un color recibido como parámetro.

6.  Un método Ordenar que recibe una lista de objetos Forma y la ordena de acuerdo al valor de su área.

7.  Un método Reducir que recibe una lista de objetos Forma y una cantidad y elimina de esa lista los elementos cuya área sea menor que ese valor recibido.

8.  Unas líneas de código que creen un objeto Tablero,  obtiene la lista de todos los elementos de color rojo en el tablero, los ordene, y por último, elimine  de esa lista a los elementos que tengan un área menor que 10.
*/