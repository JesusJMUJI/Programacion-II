using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ7._2 {
    internal class Program {
        public class Pelota {
            public double radio;
            public string color;

            public Pelota(double radio = 1.5, string color = "Blanco") {
                this.radio = radio;
                this.color = color;
            }

            public string Descripcion() {
                return $"Soy una pelota de radio {radio} y de color {color}";
            }

            public string Color() {
                return color;
            }

            public static Pelota[] FiltrarPorColor(Pelota[] pelotas, string color) 
            {
                Pelota[] pelotasFiltradas = new Pelota[pelotas.Length];
                int contador = 0;
                
                foreach (Pelota elemento in pelotas) 
                {
                    if (elemento.Color() == color) 
                    {
                        pelotasFiltradas[contador] = elemento;
                        contador++;
                    }
                }

                Pelota[] pelotasFiltradasFinal = new Pelota[contador];

                for (int i = 0; i < contador; i++) 
                {
                    pelotasFiltradasFinal[i] = pelotasFiltradas[i];
                }

                return pelotasFiltradasFinal;
            }

        }

        public static void Main(string[] args) 
        {
            // Construir objetos p1, p2 y p3
            Pelota p1 = new Pelota(3.2, "Rojo");
            Pelota p2 = new Pelota();
            Pelota p3 = new Pelota(p1.radio * p2.radio, "Verde");

            // Mostrar descripciones
            Console.WriteLine(p1.Descripcion());
            Console.WriteLine(p2.Descripcion());
            Console.WriteLine(p3.Descripcion());

            Pelota[] pelotas = new Pelota[10];

            for (int i = 0; i < pelotas.Length; i++) 
            {
                //string color = i % 2 == 0 ? "Rojo" : "Verde";

                string color;
                if (i % 2 == 0) color = "Rojo";
                else color = "Verde";

                double radio = i + 2;
                pelotas[i] = new Pelota(radio, color);
            }

            // Mostrar descripciones de las pelotas verdes
            foreach (Pelota elemento in pelotas) 
            {
                if (elemento.Color() == "Verde") 
                {
                    Console.WriteLine(elemento.Descripcion());
                }
            }



        }
    }
}
