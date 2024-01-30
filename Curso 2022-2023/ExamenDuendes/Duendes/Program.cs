using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duendes
{
    internal class Program
    {
        public class CampoDeJuego
        {
            public int XMax;
            public int YMax;

            public CampoDeJuego(int XMax, int YMax)
            {
                this.XMax = XMax;
                this.YMax = YMax;
            }
        }

        public class Duende
        {
            public int PosX;
            public int PosY;
            public int Energia;
            CampoDeJuego campoDeJuego;

            public Duende(CampoDeJuego campoDeJuego, int energia)
            {
                this.campoDeJuego = campoDeJuego;
                this.Energia = energia;
            }

            public void Posicion(int posX, int posY)
            {
                this.PosX = posX;
                this.PosY = posY;
            }

            public void Moverse()
            {
                Random rnd = new Random();
                int randomPosX = rnd.Next(-3,4);
                int randomPosY = rnd.Next(-3,4);

                if (randomPosX > campoDeJuego.XMax || randomPosX < campoDeJuego.XMax && randomPosY > campoDeJuego.YMax || randomPosY < campoDeJuego.YMax )
                {
                    Posicion(randomPosX, randomPosY);
                }
                else
                {
                    Moverse();
                }

            }

            public virtual string Actuar()
            {
                return "";
            }
        }

        public class Revoltoso : Duende
        {
            public Revoltoso(CampoDeJuego campoDeJuego, int energia) : base(campoDeJuego, energia){ }

            public override string Actuar()
            {
                Random rnd = new Random();
                
                string[] cadenasActuar = {"ji, ji" , "¡ahuuu!", "¡Hey!"};
                int randomCadena = rnd.Next(0,cadenasActuar.Length);

                if (this.Energia < 0)
                {
                    return "";
                }
                else
                {
                    return cadenasActuar[randomCadena];
                }
            }
        }

        public class Coleccionista : Duende
        {
            List<Tesoro> listTesoros;
            Random rnd = new Random();
            public Coleccionista(CampoDeJuego campoDeJuego, int energia) : base(campoDeJuego,energia) 
            {
                listTesoros = new List<Tesoro>();
            }
            
            public void Añadir() {}
        
            public class Tesoro {}
            public override string Actuar()
            {
                if (listTesoros.Count == 0) return "";
                int tesoroAQuitar = rnd.Next(0,listTesoros.Count);
                Tesoro tesoroEscogido = listTesoros[tesoroAQuitar];

                listTesoros.RemoveAt(tesoroAQuitar);
                return Convert.ToString(tesoroEscogido);
            }
        }

        public void Golpear(List<Duende> listDuendes, int posX, int posY, int n)
        {

            for (int i = 0; i < listDuendes.Count; i++)
            {
                if(listDuendes[i].PosX < n - posX && listDuendes[i].PosY < n - posY)
                {
                    listDuendes[i].Energia -= n;

                    if (listDuendes[i].Energia < 0)
                    {
                        listDuendes.RemoveAt(i);
                        i--;
                    }
                } 
            }
        }

        public string MensajeColeccionistas(Coleccionista[] arrayDuendes)
        {
            string cadenaAcumulada = "";
            foreach (var duende in arrayDuendes)
            {
                cadenaAcumulada += duende.Actuar();
            }
            return cadenaAcumulada;
        }

        public Duende[] NDuendesMayorEnergia(int N, Duende[] arrayDuendes)
        {
            Duende[] arrayDuendesMaxEnergy = new Duende[arrayDuendes.Length];
            int contador = 0;
            Duende aux = null;
            for (int i = 0; i < arrayDuendes.Length; i++)
            {
                if (arrayDuendes[i].Energia < N && arrayDuendes[i].Energia > N)
                {
                    arrayDuendesMaxEnergy[contador] = arrayDuendes[i];
                    contador++;
                }
            }

            for (int i = 0; i < arrayDuendesMaxEnergy.Length; i++)
            {
                if (arrayDuendesMaxEnergy[i].Energia > arrayDuendesMaxEnergy[i + 1].Energia)
                {
                    aux = arrayDuendesMaxEnergy[i];
                    arrayDuendesMaxEnergy[i] =  arrayDuendesMaxEnergy[i + 1];
                    arrayDuendesMaxEnergy[i + 1] = aux;
                }
            }

            return arrayDuendesMaxEnergy;
        }

        public List<Revoltoso> DevolverRevoltosos(List<Duende> listDuendes, List<Revoltoso> listRevoltoso = null, int contador = 0)
        {
            if (listRevoltoso == null) { listRevoltoso = new List<Revoltoso>(); }

            if (contador == listDuendes.Count)
            {
                return listRevoltoso;
            }
            else if (listDuendes[contador] is Revoltoso)
            {
                listRevoltoso.Add((Revoltoso)listDuendes[contador]);
            }
            return DevolverRevoltosos(listDuendes, listRevoltoso, contador++);
        }

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

        public class PilaNodosDuende
        {
            public NodoDuende ultimo;
            public int Count;
            public PilaNodosDuende()
            {
                ultimo = null;
                Count = 0;
            }
            
            public Duende Pop(Duende d)
            {
                Duende sol = ultimo.d;

                ultimo = ultimo.anterior;
                Count--;

                return sol;
            }
            
            public void Push(Duende d)
            {
                NodoDuende nuevo = new NodoDuende(d);

                nuevo.anterior = ultimo;
                ultimo = nuevo;

                Count++;
            }
        }
    }
}
