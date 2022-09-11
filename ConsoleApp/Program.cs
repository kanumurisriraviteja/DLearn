using ConsoleApp.Core;
using ConsoleApp.Test;

namespace ConsoleApp;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("==Hello World==");
        Program p = new Program();
        p.Learn();
        Console.WriteLine("==Bye==");
        Console.ReadLine();
    }

    private void DOM()
    {
        DataType d0 = new DataType();
        d0.Learn();

        Operators d1 = new Operators();
        d1.Learn();

        // static class - start
        // Accessing the static variables/methods   -- 1st time 
        Console.WriteLine(Sl.a0); // calling static variable
        Sl.Learn(); // calling static method, static class


        // Accessing the static variables/methods   -- 2nd time 
        Console.WriteLine(Sl.a0);
        Sl.Learn();
        // static class - end


        // Non static class -static members- start
        Console.WriteLine(Nsl.a0);  // should be access via the class name;
        Nsl.Learn();   // static method , non static class


        Console.WriteLine(Nsl.a0);  // should be access via the class name;
        Nsl.Learn();   // static method , non static class
                       // Non static class - end

        // Non static class -non static members- start   -- start
        // Accessing the non static variables/methods     -- 1st time
        Nsl d2 = new Nsl();
        // Console.WriteLine(d.a0); // Error can be accesed.
        // Console.WriteLine(Nsl.a1);  // Error should be accessed via the object
        Console.WriteLine(d2.a1);
        Console.WriteLine(d2.a1);
        // Nsl.Learn1();   // Error 
        d2.Learn1();     // instance method
        d2.Learn1();     // instance method


        // Accessing the non static variables/methods     -- 2st time
        Nsl d3 = new Nsl();
        Console.WriteLine(d3.a1);
        d3.Learn1();

        // Non static class -non static members- start   -- end


    }

    private void Learn()
    {
        // Pracitical use of static and non static varaibles -- start
        UsrOne u1 = new UsrOne();
        u1.Learn();

        UsrTwo u2 = new UsrTwo();
        u2.Learn();
        // Pracitical use of static and non static varaibles -- end

    }


}