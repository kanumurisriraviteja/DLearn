using ConsoleApp.Core;
using ConsoleApp.Test;
using ConsoleApp.PracProg;
using System.Threading;

namespace ConsoleApp;
public class Program : Object
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("==Hello World==");
            Program p = new Program();
            p.Learn();
            //p.Practise();

            Console.WriteLine("==Bye==");
            Console.ReadLine();
        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
    }

    private void Practise()
    {
        _1ProLearn p1 = new _1ProLearn();
        p1.Learn();
    }

    private void Learn()
    {
        // DOM();
        // Logic();
        // oopsPrinciples();
        // ELD();
        // MultiEval();
        // others();
    }

    private void DOM()
    {
        _2DataType d0 = new _2DataType();
        d0.Learn();

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
        Console.WriteLine(_4Nsl.a6);  // should be access via the class name;
        _4Nsl.Learn();   // static method , non static class
                         // Non static class - end

        // Non static class -non static members- start   -- start
        // Accessing the non static variables/methods     -- 1st time
        _4Nsl d2 = new _4Nsl();
        // Console.WriteLine(d.a0); // Error can be accesed.
        // Console.WriteLine(Nsl.a1);  // Error should be accessed via the object
        Console.WriteLine(d2.a1);
        Console.WriteLine(d2.a1);
        Console.WriteLine(_4Nsl.a6);
        // Nsl.Learn1();   // Error 
        d2.Learn1();     // instance method
        d2.Learn1();     // instance method

        // Accessing the non static variables/methods     -- 2st time
        _4Nsl d3 = new _4Nsl();
        Console.WriteLine(d3.a1);
        d3.Learn1();

        // Non static class -non static members- start   -- end

        // Pracitical use of static and non static varaibles -- start
        UsrOne u1 = new UsrOne();
        u1.Learn();

        UsrTwo u2 = new UsrTwo();
        u2.Learn();
        // Pracitical use of static and non static varaibles -- end

        _5Operators d1 = new _5Operators();
        d1.Learn();


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
    private void oopsPrinciples()
    {
        //  _10IntLearn  o0 = new _10IntLearn(); // Error
        _10IntLearn o8 = new FederalBank(); // valid
        _10IntLearn o9;
        FederalBank o10 = new FederalBank();
        o9 = o10;
        FederalBank f = new FederalBank();
        Console.WriteLine(_10IntLearn.iVar);
        f.IntrestRate();

        //  _11AbsLearn o1 = new _11AbsLearn();// Error
        _11AbsLearn o7 = new FederalBank();  //valid

        _12oopsbase o2 = new _12oopsbase();
        o2.m1();// can be accessed  This is m1 method in _12oopsbase class:10
        //o2.m2(); // Error cant be accessed;
        //o2.a2; // Errror
        o2.m3();//This is m3 method in _12oopsbase class
        o2.m4();//This is m4 method in _12oopsbase class
        o2.m5();//This is m5 method in _12oopsbase class
        o2.m6();//This is m6 method in _12oopsbase class
        o2.m7();//This is m7 method in _12oopsbase class

        TestOne o1 = new TestOne();
        o1.m1();//This is m1 method in _12oopsbase class:10
        o1.m2();//This is m2 method in Testone class:10
        o1.m3();//This is m3 method in _12oopsbase class
        o1.m4();//This is m4 method in Testone class
        o1.m5();//This is m5 method in Testone class
        o1.m6();//This is m6 method in Testone class
        o1.m7();//This is m7 method in Testone class

        _12oopsbase o4 = new TestOne();
        o4.m1();//This is m1 method in _12oopsbase class:10
        //o4.m2(); Error can't be accessed
        o4.m3(); //This is m3 method in _12oopsbase class
        o4.m4();//This is m4 method in Testone class       // method overriding 
        o4.m5();//This is m5 method in _12oopsbase class
        o4.m6(); //This is m6 method in _12oopsbase class
        o4.m7();//This is m7 method in _12oopsbase class


        // TestOne o5 = new _12oopsbase(); // Error - compiletime
        // TestOne o6 = (TestOne)new _12oopsbase();// Error - runtime

        TestThree o3 = new TestThree();
        Console.WriteLine(o3.a0);
        Console.WriteLine(o3.a2);
        o3.m1();
        o3.m2();

        // Calling constructor
        Console.WriteLine("Calling constructor");
        TestOne o11 = new TestOne();
        TestOne o12 = new TestOne("Hi we are learning parameterised const");

    }

    private void ELD()
    {
        // Accessing from enum
        System.Console.WriteLine(_14en.Jan);

        _15Ex a1 = new _15Ex();
        a1.Learn();

        _20lam lam = new _20lam();
        lam.Learn();

        _18Del del = new _18Del();
        del.Learn();

    }
    private void others()
    {
        // Indexers
        _17Ind ic = new _17Ind();
        ic.valuearr = new string[] { "C", "CPP", "c#" }; // without indexer 

        foreach (var i in ic.valuearr)
        {
            System.Console.WriteLine(i);
        }
        // with indexer
        ic[0] = "C";
        ic[1] = "CPP";
        ic[2] = "CSHARP";

        System.Console.WriteLine(ic[0]);

        // Extensions Methods - Created in the static class _3Sl
        // This acts like a method extension
        string a = "teja";
        Console.WriteLine(a.CountVowels(a));
    }

    private void MultiEval()
    {
        _16Mult _16Mult = new _16Mult();
        _16Mult.Learn(); // Multi Threading
        _16Mult.LearnMt();// async , wait, task
    }

}