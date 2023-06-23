using System.Diagnostics.Contracts;
using System.Reflection;

internal class Program
{
    static void Main()
    {
        Hormiguero hormiguero = new Hormiguero();

        for (int i = 0; i < 10; i++)
        {
            hormiguero.AñadeHormigas();
        }

        Console.WriteLine(hormiguero.DefiendeHormiguero(25));
        List<Hormiga> listHormigas = hormiguero.DameFilaHormigas(5);

        foreach (var hormiga in listHormigas)
        {
            Console.WriteLine(hormiga.energia);
        }
    }

    public enum Color {Negro, Rojo, Marron};

    public class Hormiga
    {
        public float energia { get; private set; }
        public float ConsumoEnergia { get;}
        public Color color {get;}

        public Hormiga(float energia, float consumoEnergia, Color color)
        {
            this.energia = energia;
            this.ConsumoEnergia = consumoEnergia;
            this.color = color;
        }

        public void SetEnergia (float cantidad)
        {
            this.energia = cantidad;
        }

        public virtual string HacerFaena ()
        {
            return $"Soy una hormiga sin faena con energia {energia}";
        }

        public void Alimentate(float cantidad)
        {
            this.energia += cantidad;
        }
    }

    public class Guerrera : Hormiga
    {
        public Guerrera(float energia, float consumoEnergia, Color color) : base(energia,consumoEnergia,color) {}
        public override string HacerFaena ()
        {
            return $"Soy una hormiga guerrera con energia: {energia - ConsumoEnergia}";
        }
    }
    public class Obrera : Hormiga
    {
        public Obrera(float energia, float consumoEnergia, Color color) : base(energia,consumoEnergia,color) {}
        public override string HacerFaena ()
        {
            return $"Soy una hormiga obrera con energia: {energia - ConsumoEnergia}";
        }
    }

    public class Reina : Hormiga
    {

        public Reina(float energia, float consumoEnergia) : base(energia,consumoEnergia,Color.Rojo) {}
        public override string HacerFaena()
        {
            return $"Soy una hormiga reina con energia {energia - ConsumoEnergia}";
        }
        public Hormiga[] CrearHormigas()
        {
            Random rnd = new Random();
            int tamRandom = rnd.Next(10, 21);
            Hormiga[] arrayHormigas = new Hormiga[tamRandom];

            for (int i = 0; i < arrayHormigas.Length; i++)
            {
                if (rnd.Next(0,1) == 0)
                {
                    arrayHormigas[i] = new Guerrera(8,2, (Color)rnd.Next(0,3));
                }
                else
                {
                    arrayHormigas[i] = new Obrera(5,1, (Color)rnd.Next(0,3));
                }
            }
            return arrayHormigas;
        }
    }

    public class Hormiguero
    {
        Reina reina = new Reina(10, 3);
        List<Hormiga> listHormigas = new List<Hormiga>();

        public void AñadeHormigas()
        {
            Hormiga[] arrayHormigas = reina.CrearHormigas();
            foreach (var hormiga in arrayHormigas)
            {
                listHormigas.Add(hormiga);
            }
        }

        public List<Hormiga> DameFilaHormigas(int numHormigas)
        {
            List<Hormiga> tempHormigas = new List<Hormiga>();
            int contadorHormigas = 0;

            foreach (var hormiga in listHormigas)
            {
                if (hormiga.GetType() == typeof(Obrera))
                {
                    contadorHormigas++;
                }
            }

            if (numHormigas == contadorHormigas)
            {
                foreach (var hormiga in listHormigas)
                {
                    if (hormiga.GetType() == typeof(Obrera))
                    {
                        tempHormigas.Add(hormiga);
                    }
                }

                return tempHormigas;
            }
            else
            {
                return null;
            }
        }

        public bool DefiendeHormiguero (float cantidad)
        {
            float acumulado = 0;

            for (int i = 0; i < listHormigas.Count; i++)
            {
                if(listHormigas[i].GetType() == typeof(Guerrera))
                {
                    acumulado += listHormigas[i].energia;
                    listHormigas.RemoveAt(i);
                    i--;
                }
                if (acumulado > cantidad)
                {
                    return true;
                }
            }
            return true;
        }

        public Hormiga[] NHormigasMaxEnergia (int N)
        {
            Hormiga[] arrayHormigas = new Hormiga[N];
            int index = 0;
            foreach (var hormiga in listHormigas)
            {
                if(hormiga.energia > N)
                {
                    arrayHormigas[index] = hormiga;
                    index++;
                }
            }
            if (arrayHormigas.Length > 1)
            {
                return arrayHormigas;
            }
            else
            {
                return null;
            }
        }
    }

    public class NodoHormiga
    {
        public Hormiga dato;
        public NodoHormiga sig;
        public NodoHormiga(Hormiga dato)
        {
            this.dato = dato;
            this.sig = null;
        }
    }

    public class PilaNodosHormigas
    {
        NodoHormiga primerNodo = null;
        // Pilas : D --> A --> B --> C 
        // Pop: Quitar el primero, devolver y desconectar
        // n(A) --> n(B) --> n(C)   ----> n(A) !=> 1 n(B) -->  2 n(C)
        // Push: añadir encima
        public Hormiga Pop()
        {
            NodoHormiga nodoQuitar = primerNodo;
            primerNodo = primerNodo.sig;
            nodoQuitar.sig = null;
            return nodoQuitar.dato;
        }
        public void Push(Hormiga h)
        {
            NodoHormiga nodoNuevo = new NodoHormiga(h);
            nodoNuevo.sig = primerNodo;
            primerNodo = nodoNuevo;
        }
    }


    public class BiNodoHormiga
    {
        public Hormiga dato;
        public BiNodoHormiga sig;
        public BiNodoHormiga prev;
        public BiNodoHormiga(Hormiga dato)
        {
            this.dato = dato;
            this.sig = null;
            this.prev = null;
        }
    }
    public class QueueNodosHormigas
    {
        BiNodoHormiga primerNodo = null;
        BiNodoHormiga ultimoNodo = null;
        // Queue : 1A <--> B <--> 2C
        // Pop : 
        // Push : 
        public Hormiga Pop()
        {
            if(primerNodo == ultimoNodo){
                BiNodoHormiga returnNodo = primerNodo;
                primerNodo = null;
                ultimoNodo = null;
                
                return returnNodo.dato;
            }


            BiNodoHormiga penultimoNodo = ultimoNodo.prev;
            BiNodoHormiga nodoReturn = ultimoNodo;
            penultimoNodo.sig = null;
            ultimoNodo.prev = null;
            ultimoNodo = penultimoNodo;
            return nodoReturn.dato;



/*            
            BiNodoHormiga recorrerNodos = primerNodo;
            while(recorrerNodos.sig.sig != null)
            {
                recorrerNodos = recorrerNodos.sig;
            }
            BiNodoHormiga nodoReturn = recorrerNodos.sig;
            recorrerNodos.sig = null;
            return nodoReturn.dato; */
        }
        public void Push(Hormiga h)
        {   // 1-null

            BiNodoHormiga nodoAñadir = new BiNodoHormiga(h); // 1null A

            if(primerNodo == null && ultimoNodo == null){ // si no hay elementos en la cola
                primerNodo = nodoAñadir;
                ultimoNodo = nodoAñadir;
                return;
            }

            nodoAñadir.sig = primerNodo; // A --> 1null
            primerNodo.prev = nodoAñadir; // A --> 1null // ERROR due to null.prev
            primerNodo = nodoAñadir;
        }
    }
}