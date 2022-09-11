using ConsoleApp.Core;

namespace ConsoleApp;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("==Hello World==");

        //    DataType d = new DataType();
        // Operators d = new Operators();

        // static class - start
        // Accessing the static variables/methods   -- 1st time 
        Console.WriteLine(Sl.a0); // calling static variable
        Sl.Learn(); // calling static method, static class


        // Accessing the static variables/methods   -- 2nd time 
        Console.WriteLine(Sl.a0);
        Sl.Learn();
        // static class - end


        // Non static class - start
        Console.WriteLine(Nsl.a0);  // should be access via the class name;
        Nsl.Learn();   // static method , non static class


        Console.WriteLine(Nsl.a0);  // should be access via the class name;
        Nsl.Learn();   // static method , non static class
        // Non static class - end




        // Accessing the non static variables/methods     -- 1st time
        Nsl d = new Nsl();
        // Console.WriteLine(d.a0); // Error can be accesed.
        // Console.WriteLine(Nsl.a1);  // Error should be accessed via the object
        Console.WriteLine(d.a1);
        Console.WriteLine(d.a1);
        // Nsl.Learn1();   // Error 
        d.Learn1();     // instance method
        d.Learn1();     // instance method


        // Accessing the non static variables/methods     -- 2st time
        Nsl d1 = new Nsl();
        Console.WriteLine(d1.a1);
        d1.Learn1();


        Console.WriteLine("==Bye==");
        Console.ReadLine();
    }
}