using ConsoleApp.Core;

namespace ConsoleLib
{
    public class ConsLibLearn
    {
        public void Learn()
        {
            _4Nsl o1 = new _4Nsl();
            Console.WriteLine(o1.a1); // Accessable
            // Console.WriteLine(o1.a2); // Priavte not Accessable
            // Console.WriteLine(o1.a3); // protected not accesable
            // Console.WriteLine(o1.a4);//internal not accesable
            // Console.WriteLine(o1.a5); // protected internal not accessable

        }
    }
}