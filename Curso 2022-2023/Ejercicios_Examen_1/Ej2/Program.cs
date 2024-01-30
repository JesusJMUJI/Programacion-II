using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    internal class Program
    {
        public class H1
        {
            public virtual void p()
            {
                Console.WriteLine("p de H1");
            }
            public void q()
            {
                Console.WriteLine("q de H1");
            }
        }

        public class H2 : H1
        {
            public override void p()
            {
                Console.WriteLine("p de H2");
            }
        }
        public class H3 : H2 { }
        public class H4 : H1 { }

        public static void Main()
        {
            H3 unH3 = new H3();
            unH3.p();
            unH3.q();
            H1 unH1 = new H1();
            unH1.p();
            H4 unH4 = new H4();
            unH4.p();
        }
    }
}
