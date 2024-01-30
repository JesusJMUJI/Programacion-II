namespace Duende;

internal class Program
{
    static void Main()
    {
        CampoJuego cj = new CampoJuego(300,300);
    }


    public class CampoJuego
    {
        // Atributo SIN PROPIEDADES -- NECESITA UN GETTER (GetXMax)
        public int XMax {get;}

        // Atributo CON propiedades ({get; set;})
        public int YMax {get;}

        public CampoJuego(int XMax, int YMax)
        {
            this.XMax = XMax;
            this.YMax = YMax;
        }

    /*  public int GetXMax()
        {
            return XMax;
        }

        public void SetXMax (int XMax)
        {
            this.XMax = XMax;
        }

        public void SetYMax (int YMax)
        {
            this.YMax = YMax;
        } */
    }
        
    public class Duende
    {
        public int PosX {get; private set;}
        public int PosY {get; private set;}
        public int NEnergia {get; private set;}
        CampoJuego CJ;
        protected Random rnd = new Random();
        
        public Duende(int PosX, int PosY, int NEnergia, CampoJuego CJ)
        {
            this.PosX = PosX; this.PosY = PosY;
            this.NEnergia = NEnergia;
            this.CJ = CJ;
        }
        
        public void SetEnergia (int energia)
        {
            this.NEnergia = energia;
        }

        public virtual string Actuar() { return ""; }
            
        public void Moverse()
        {
            int randomX = rnd.Next(-3,4);
            int randomY = rnd.Next(-3,4);
            
            if (randomX > CJ.XMax && randomX < CJ.XMax && randomY > CJ.YMax && randomY < CJ.YMax)
            {
                PosX = randomX;
                PosY = randomY;
                NEnergia--;
            }
        }
        public void RestarEnergia(int energia)
        {
            NEnergia -= energia;
        }
    }
        
    public class Revoltoso : Duende
    {
        public Revoltoso(int PosX, int PosY, int NEnergia, CampoJuego CJ) : base(PosX,PosY,NEnergia,CJ) {}
        
        public override string Actuar()
        {
            if( NEnergia > 0 ) { return "";}
            string[] arrayCad= {"ji,ji", "¡ahuuu!", "¡Hey!"};
            int randomI = rnd.Next(0,arrayCad.Length);
            return arrayCad[randomI];
        }
    }
        
    public class Tesoro {}
    public class Coleccionista : Duende
    {
        public Coleccionista(int PosX, int PosY, int NEnergia, CampoJuego CJ) : base(PosX,PosY,NEnergia,CJ){}
        
        List<Tesoro> listTesoros = new List<Tesoro>();
            
        public void Anagdir(){}
            
        public override string Actuar()
        {
            if (listTesoros.Count == 0)
            {
                return "";
            }
            int random = rnd.Next(0,listTesoros.Count);
            Tesoro tesoro = listTesoros[random];
            listTesoros.RemoveAt(random);
            return $"{tesoro}";
        }
    }
        
    public void Golpear(List<Duende> listDuendes, int n, int posX, int posY)
    {
        foreach(Duende duende in listDuendes){
            int distX = duende.PosX - posX; if (distX < 0) { distX *= -1; }
            int distY = duende.PosY - posY; if (distY < 0) { distY *= -1; }

            if (distX < n && distY < n){
                duende.RestarEnergia(n);
            }
        }
        
        for (int i = 0; i < listDuendes.Count; i++)
        {
            if (listDuendes[i].NEnergia < 0)
            {
                listDuendes.RemoveAt(i);
                i--;
            }
        }
        /* foreach(Duende duendeA in listDuendes){
            foreach(Duende duendeB in listDuendes){
                if(duendeA != duendeB)
                {
                    int distX = duendeB.PosX - duendeA.PosX; if (distX < 0) { distX *= -1; }
                    int distY = duendeA.PosY - duendeB.PosY; if (distY < 0){ distY *= -1; }

                    if (distX < n && distY < n){
                        duendeA.NEnergia -= n;

                    }
                }
            }
        } */
        

        // int i = 0;
        // int j = 0;
        // while (i < listDuendes.Count)
        // { 
        //     while (j < listDuendes.Count)
        //     {
        //         if (listDuendes[j].PosX < listDuendes[j + 1].PosX && listDuendes[j].PosY <  listDuendes[j + 1].PosY)
        //     }
        //     j = 0;
        // } 
    }

    public string MensajeColeccionistas (Duende[] arrayDuende)
    {
        string returnString = "";
        
        foreach (var duende in arrayDuende)
        {
            if (duende.GetType() == typeof(Coleccionista))
            {
                returnString += duende.Actuar();
                returnString += ",";
            }
        }

        return returnString;
    }

    public Duende[] NDuendesMayorEnergia(int param, Duende[] arrayDuende)
    {
        Duende[] returnArray = new Duende[arrayDuende.Length];
        int i = 0;
        foreach (var duende in arrayDuende)
        {
            if (duende.NEnergia >= param)
            {
                returnArray[i] = arrayDuende[i];
                i++;
            }
        }
        return returnArray;
    }

    public List<Duende> DevolverRevoltosos(List<Duende> listDuende, List<Duende> listRevoltosos = null, int cont = 0)
    {
        if (listRevoltosos == null)
        {
            listRevoltosos = new List<Duende>();
            // No es necesario llamar a la funcion al inicializar la lista --> DevolverRevoltosos(listDuende, listRevoltosos, cont);
        }

        if (listDuende[cont].GetType() == typeof(Revoltoso))
        {
            listRevoltosos.Add(listDuende[cont]);
            cont++;
            DevolverRevoltosos(listDuende, listRevoltosos, cont);
        }
        else if(cont == (listDuende.Count - 1) /* && No es necesario comprobar esto debido a que se comprueba al primer if --> listDuende[cont].GetType() != typeof(Revoltoso)*/)
        {
            return listRevoltosos;
        }
        else
        {
            cont++;
            DevolverRevoltosos(listDuende, listRevoltosos, cont);
        }

        return listRevoltosos;
    }

/*     public List<Duende> DevolverRevoltosos(List<Duende> listDuende, List<Duende> listRevoltosos = null, int cont = 0)
    {
        if (listRevoltosos == null)
        {
            listRevoltosos = new List<Duende>();
            // No es necesario llamar a la funcion al inicializar la lista --> DevolverRevoltosos(listDuende, listRevoltosos, cont);
        }

        if (listDuende[cont].GetType() == typeof(Revoltoso))
        {
            listRevoltosos.Add(listDuende[cont]);
            cont++;
        }
        if(cont == (listDuende.Count - 1)//we've reached the end so can return
        {
            return listRevoltosos;
        }

        //start the next iteration
        return DevolverRevoltosos(listDuende, listRevoltosos, cont);

    } */

    public class NodoDuende
    {
        public Duende d;
        public NodoDuende anterior;
        public NodoDuende(Duende d)
        {
            this.d = d;
            this.anterior = null;
        }
    }

    // A --> B --> C

    public class PilaNodosDuendes
    {
        NodoDuende primerDuende = null;
        public Duende Pop()
        {
            if (primerDuende == null)
            {
                return null;
            }
            NodoDuende nodoAQuitar = primerDuende;
            NodoDuende nodoAnterior = primerDuende.anterior;

            nodoAnterior.anterior = null;
            primerDuende = nodoAnterior;
            return nodoAQuitar.d;
        }

        public void Push(Duende d)
        {
            NodoDuende nodoAnagdir = new NodoDuende(d);
            nodoAnagdir.anterior = primerDuende;
            primerDuende = nodoAnagdir;
        }
    }
}