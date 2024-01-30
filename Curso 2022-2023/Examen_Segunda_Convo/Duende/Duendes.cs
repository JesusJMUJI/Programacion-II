
namespace Duende;

public class CDuende{}

public class NodoDuende 
{
    public CDuende data;
    public NodoDuende anterior = null;
    public NodoDuende(CDuende data) {
        this.data = data;
    }
}

public class PilaNodosDuendes
{
    NodoDuende firstElem = null;
    public CDuende Pop()
    {
        if(firstElem == null)
        {
            return null;
        }
        NodoDuende nodeToRem = firstElem;
        NodoDuende prevNode = firstElem.anterior;

        nodeToRem.anterior = null;

        firstElem = prevNode;

        return nodeToRem.data;
    }

    // FIRST
    // A --> B --> C
    // #
    //       B --> C
    // 1 --> 2

    public void Push(CDuende d)
    {
        NodoDuende nodeToAdd = new NodoDuende(d);
        nodeToAdd.anterior = firstElem;
        firstElem = nodeToAdd;
    }

    public int ContarDuendes()
    {
        int cont = 0;
        NodoDuende other = firstElem;

        while(other != null)
        {
            cont++;
            other = other.anterior;
        }

        return cont;
    }
    //FIRST [|]
    // ||nodeToAdd --> A -- > B --> C //
}


/*Dada la siguiente declaración de clase:
    public class NodoDuende {
        public Duende d;
        public NodoDuende anterior;
        public NodoDuende(Duende d) {
            this.d = d;
            this.anterior = null;
        }
    }

Escribe otra clase PilaNodosDuendes que presente la funcionalidad básica de una
estructura dinámica de datos tipo pila, utilice la clase NodoDuende y contenga los métodos public Duende Pop(), que devuelve el duende que corresponde de la
PilaNodosDuendes y public void Push(Duende d), que añade el duende pasado
como parámetro a la PilaNodosDuendes. En una PilaNodosDuendes también se
puede conocer el número de duendes que contiene. */