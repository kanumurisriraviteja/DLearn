namespace ConsoleApp.Core;

public class _4Nsl
{
    public static int a0 = 1;
    public int a1 = 2;
    private int a2 = 25;
    protected int a3 = 24;
    internal int a4 = 36;
    protected internal int a5 = 66;

    static _4Nsl()
    {
        Console.WriteLine("static constructor in NSL class");
    }
    public _4Nsl()
    {
        Console.WriteLine("Non static constructor in NSL class");
    }

    public static void Learn()
    {
        int a2 = 3;
        Console.WriteLine(_4Nsl.a0);
        //Console.WriteLine(a1);  // Error object reference is required
        _4Nsl o1 = new _4Nsl();
        Console.WriteLine(o1.a1);   // this is how non static variables are being accessed.

        //Learn1();// Error object reference is required
        o1.Learn1(); // public method

        //Learn2();  // Error object reference is required
        o1.Learn2(); // private method

        o1.Learn3();  // protected method

        o1.Learn4();  // internal method

    }

    public void Learn1()
    {
        // Accessing the public variables
        int a2 = 3;
        Console.WriteLine(a0); // accessing class level static variable
        Console.WriteLine(a1); // accessing class leve non static variable

        // Accessing the private method. can be accessed directly without the object reference
        Learn2();

        // Accessing the private variable, the preference is always given to the local variable
        Console.WriteLine(a2);


        // Accessing the protected method
        Learn3();
        // Accessing the protected variable
        Console.WriteLine(a3);  // class level protected variable

        // Accessing the internal methods/variables
        Console.WriteLine(a4);
        Learn4();
        Console.WriteLine("Learn1 Method");
    }

    private void Learn2()
    {
        Console.WriteLine("Learn2 Method");
        Learn3();

    }

    protected void Learn3()
    {
        Console.WriteLine("Learn3 Method");
    }

    internal void Learn4()
    {
        Console.WriteLine("Learn4 Method");
    }
}