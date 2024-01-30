using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Discord_Saul
{
    internal class Recursivo
    {
        public void Main()
        {
            string cadena = "(()(()))";
            Balanceada(cadena);
        }

        public string Balanceada(string cadena)
        {
            if ()
            {

            }
            else
            {

            }
        }
    }
}

/*

Escribir un método recursivo que indique si una cadena, en el que sólo puede haber los caracteres ‘)’ y ‘(‘, está balanceada o no. 

Algunos ejemplos de cadenas balanceadas son: “()”,  null,  “()()()”, “(()(()))”. 

Las siguientes cadenas, por ejemplo, no tienen paréntesis balanceados: “()(”,    “()()))()”,    “)(”,    “(”. 

2.   public int CuentaDigitos(int n) 
        {
            if (n / 10 == 0) 
            {
                return 1;
            }
            return 1 + CuentaDigitos(n / 10);
        }
  
3.  El valor inicial que se pasa a pos es 0.
      
    public char[] InvierteArray(char[] v, int pos) 
    {
            if (pos == v.Length) 
            {
                return new char[v.Length];
                int[] aux = InvierteArray(v, pos + 1);
                aux[pos] = v[v.Length -1 - pos];
            }    
        return aux;
    }

*/
