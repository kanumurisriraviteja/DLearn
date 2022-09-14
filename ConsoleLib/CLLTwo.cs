using ConsoleApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLib
{
    public class CLLTwo : Nsl
    {
        public void Learn()
        {
            Nsl o1 = new Nsl();
            Console.WriteLine(o1.a1); // Accessable
            //Console.WriteLine(o1.a2); // Error Priavte not Accessable
            //Console.WriteLine(o1.a3); // Error protected not accesable
            //Console.WriteLine(o1.a4); // Error internal not accesable

            Console.WriteLine(a5); // Accesable
            CLLTwo cLL = new CLLTwo();
            Console.WriteLine(cLL.a5); // Accesable
            Console.WriteLine(base.a5); // Accesable

            //Console.WriteLine(o1.a5); // Error not accesable via the object

        }
    }
}
