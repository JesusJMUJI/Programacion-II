using static ConsoleApp1.Program;

namespace ConsoleApp1 {
    internal class Program 
    {
        public class Pelota {
            private double radio;
            private string color;

            public Pelota(double radio, string color) {
                this.radio = radio;
                this.color = color;
            }

            public Pelota() : this(1.5, "Blanco") { }

            public string Descripcion() {
                return $"Soy una pelota de radio {radio} y de color {color}";
            }
            Pelota p1 = new Pelota(3.2, "Rojo");
            Pelota p2 = new Pelota();
            Pelota p3 = new Pelota(p1.radio * p2.radio, "Verde");

            Console.WriteLine(p1.Descripcion());
            Console.WriteLine(p2.Descripcion());
            Console.WriteLine(p3.Descripcion());

            Pelota[] pelotas = new Pelota[10];

                for (int i = 0; i<pelotas.Length; i++)
            {
                double radio = i + 2;
                string color = (i % 2 == 0) ? "Rojo" : "Verde";
                pelotas[i] = new Pelota(radio, color);
            }


        foreach (Pelota pelota in pelotas) 
        {
            if (pelota.Color == "Verde") 
            {
                Console.WriteLine(pelota.Descripcion());
            }
        }
        
        public static Pelota[] FiltrarPorColor(Pelota[] pelotas, string color) {
            List<Pelota> pelotasFiltradas = new List<Pelota>();

            foreach (Pelota pelota in pelotas) {
                if (pelota.Color == color) {
                    pelotasFiltradas.Add(pelota);
                }
            }

            return pelotasFiltradas.ToArray();
        }
        }


        
}
}