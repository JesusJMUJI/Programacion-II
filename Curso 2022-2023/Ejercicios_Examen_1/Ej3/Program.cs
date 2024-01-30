using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    internal class Program
    {
        public class H1
        {
            private int atributo = 1;
            public virtual void p()
            {
                Console.WriteLine("p de H1");
            }
            public void q()
            {
                Console.WriteLine("q de H1");
            }
            private string r()
            {
                return "r de H1";
            }
        }

        public class H2 : H1
        {
            public int atributo = 2;
            public override void p()
            {
                Console.WriteLine("p de H2");
            }
        }
        public class H3 : H2 { }

        public static void Main()
        {
            H3 unH3 = new H3();
            unH3.atributo = 10;
            unH3.r();
            H1 unH1 = new H1();
            unH1.atributo = 10;
            unH1.r();
            H2 unH2 = new H2();
            unH2.atributo = unH1.atributo * unH3.atributo;
            unH2.r();
        }
    }
}
