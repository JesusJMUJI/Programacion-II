using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    internal class Programa_figuras
    {
        public class Figura
        {
            public virtual float Area()
            {
                return 0;
            }
        }

        public class Cuadrado : Figura
        {
            public int Lado { get; set; }

            public Cuadrado(int lado)
            {
                this.Lado = lado;
            }

            public override float Area() 
            {
                return Lado * Lado;
            }
        }

        public class Circulo : Figura
        {
            public float Radio { get; set; }

            public Circulo(int radio)
            { 
                this.Radio = radio; 
            }

            public override float Area()
            {
                return (3.14f * Radio * (Radio));
            }
        }

        public class Triangulo : Figura
        {
            public int Base { get; set; }
            public int Altura { get; set; }

            public Triangulo(int _base, int altura)
            {
                this.Base = _base;
                this.Altura = altura;
            }
            public override float Area()
            {
                return (Base * Altura) / 2;
            }
        }

        public class Jerarquía
        {
            public static void Main(string[] args)
            {
                Figura[] figuras = new Figura[3];
                figuras[0] = new Circulo(10);       // Radio
                figuras[1] = new Cuadrado(10);      // Lado
                figuras[2] = new Triangulo(10, 5);  // Base y altura
                foreach (Figura f in figuras)
                {
                    Console.WriteLine("Area: " + f.Area());
                }
            }
        }

    }
}

