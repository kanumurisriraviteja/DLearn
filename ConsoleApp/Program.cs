using ConsoleApp.Core;

namespace ConsoleApp;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("==Hello World==");

        //    DataType d = new DataType();
        // Operators d = new Operators();
        Sl.Learn(); // calling static method, static class
        Nsl d = new Nsl();
        Nsl.Learn();   // static method , non static class
        // Nsl.Learn1();   // Error 
        d.Learn1();     // instance method

        // Console.WriteLine(d.a0); // Error can be accesed.
        Console.WriteLine(Nsl.a0);  // should be access via the class name;
        // Console.WriteLine(Nsl.a1);  // Error should be accessed via the object
        Console.WriteLine(d.a1); 

        Console.WriteLine("==Bye==");
        Console.ReadLine();
    }
}