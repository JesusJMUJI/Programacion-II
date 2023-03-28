using System;

namespace Ej1
{
    internal class Ej1
    {


        public class Punto
        {
            private int x;
            private int y;

            public Punto(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public int X  
            {
                get { return x; }
                set { x = value; }
            }

            public int Y
            {
                get { return y; }
                set { y = value; }
            }
        }

        public static class OperacionesConPuntos
        {
            public static void OperacionDoblez(Punto[] puntos)
            {
                foreach (Punto elemento in puntos)
                {
                    elemento.X *= 2;
                    elemento.Y /= 2;
                }
            }

            public static Punto[] OperacionDoblezCopia(Punto[] puntos)
            {
                Punto[] copia = new Punto[puntos.Length];
                for (int i = 0; i < puntos.Length; i++)
                {
                    copia[i] = new Punto(puntos[i].X * 2, puntos[i].Y / 2);
                }
                return copia;
            }
        }
        public static void Main()
        {
            Punto[] puntos = new Punto[] { new Punto(12, 41), new Punto(44, 53) };

            Console.WriteLine("Array antes de OperacionDoblez:");
            foreach (Punto elemento in puntos)
            {
                Console.WriteLine($"({elemento.X}, {elemento.Y})");
            }

            OperacionesConPuntos.OperacionDoblez(puntos);

            Console.WriteLine("Array después de OperacionDoblez:");
            foreach (Punto punto in puntos)
            {
                Console.WriteLine($"({punto.X}, {punto.Y})");
            }

            Console.WriteLine("Array antes de OperacionDoblezCopia:");
            foreach (Punto punto in puntos)
            {
                Console.WriteLine($"({punto.X}, {punto.Y})");
            }

            Punto[] copia = OperacionesConPuntos.OperacionDoblezCopia(puntos);

            Console.WriteLine("Array después de OperacionDoblezCopia:");
            foreach (Punto punto in copia)
            {
                Console.WriteLine($"({punto.X}, {punto.Y})");
            }

            Console.WriteLine("Valor del array original:");
            foreach (Punto punto in puntos)
            {
                Console.WriteLine($"({punto.X}, {punto.Y})");
            }

        }
    }
}
