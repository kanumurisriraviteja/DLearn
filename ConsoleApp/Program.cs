using ConsoleApp.Core;
using ConsoleApp.Test;

namespace ConsoleApp;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("==Hello World==");
        Program p = new Program();
        //p.DOM();
        p.Logic();

        Console.WriteLine("==Bye==");
        Console.ReadLine();
    }

    private void DOM()
    {
        _2DataType d0 = new _2DataType();
        d0.Learn();

        _5Operators d1 = new _5Operators();
        d1.Learn();

        // static class - start
        // Accessing the static variables/methods   -- 1st time 
        Console.WriteLine(_3Sl.a0); // calling static variable
        _3Sl.Learn(); // calling static method, static class


        // Accessing the static variables/methods   -- 2nd time 
        Console.WriteLine(_3Sl.a0);
        _3Sl.Learn();
        // static class - end


        // Non static class -static members- start
        Console.WriteLine(_4Nsl.a0);  // should be access via the class name;
        _4Nsl.Learn();   // static method , non static class


        Console.WriteLine(_4Nsl.a0);  // should be access via the class name;
        _4Nsl.Learn();   // static method , non static class
                       // Non static class - end

        // Non static class -non static members- start   -- start
        // Accessing the non static variables/methods     -- 1st time
        _4Nsl d2 = new _4Nsl();
        // Console.WriteLine(d.a0); // Error can be accesed.
        // Console.WriteLine(Nsl.a1);  // Error should be accessed via the object
        Console.WriteLine(d2.a1);
        Console.WriteLine(d2.a1);
        // Nsl.Learn1();   // Error 
        d2.Learn1();     // instance method
        d2.Learn1();     // instance method


        // Accessing the non static variables/methods     -- 2st time
        _4Nsl d3 = new _4Nsl();
        Console.WriteLine(d3.a1);
        d3.Learn1();

        // Non static class -non static members- start   -- end


    }


    private void Logic()
    {
        _6DecL decL = new _6DecL();
        decL.Learn();
        _7Lpl l1 = new _7Lpl();
        l1.Learn();
        _8StrLearn s = new _8StrLearn();
        s.Learn();
        _9DatastrLearn ds = new _9DatastrLearn();
        ds.Learn();


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