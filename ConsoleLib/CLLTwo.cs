using ConsoleApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLib
{
    public class CLLTwo : _4Nsl
    {
        public void Learn()
        {
            _4Nsl o1 = new _4Nsl();
            Console.WriteLine(o1.a1); // public accessable
            //Console.WriteLine(o1.a2); // Error Private not Accessable
            // Console.WriteLine(o1.a3); // Error protected not accesable
            //Console.WriteLine(o1.a4); // Error internal not accesable
            //Console.WriteLine(o1.a5); // Error not accesable via the object
 
            CLLTwo cLL = new CLLTwo();
            Console.WriteLine(cLL.a1); // public accesable
            // Console.WriteLine(cLL.a2); // Error Private not Accessable
            Console.WriteLine(cLL.a3); // protected Accesable
            // Console.WriteLine(cLL.a4); // Error internal not Accesable
            Console.WriteLine(cLL.a5); // Accesable
            Console.WriteLine(base.a5); // Accesable
            Console.WriteLine(a5); // Accesable

           

        }
    }
}
