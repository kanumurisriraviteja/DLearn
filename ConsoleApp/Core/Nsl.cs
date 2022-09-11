namespace ConsoleApp.Core;

public class Nsl
{
    public static int a0 = 1;
    public int a1 = 2;

    private int a2 = 25;

    static Nsl()
    {
        Console.WriteLine("static constructor in NSL class");
    }
    public Nsl()
    {
        Console.WriteLine("Non static constructor in NSL class");
    }

    public static void Learn()
    {
        int a2 = 3;
        Console.WriteLine(Nsl.a0);
        // //  Console.WriteLine(a1);  // Error object reference is required
        Nsl o1 = new Nsl();
        // Console.WriteLine(o1.a1);   // this is how non static variables are being accessed.

        // // Learn1();// Error object reference is required
        // o1.Learn1();

        //Learn2();  // Error 
        // o1.Learn2();

    }

    public void Learn1()
    {
        int a2 = 3;
        Console.WriteLine(a0);
        Console.WriteLine(a1);

        // Accessing the private method
        Learn2();

        // Accessing the private variable
        Console.WriteLine(a2);
        Console.WriteLine("==Learn1===");
    }

    private void Learn2()
    {
        Console.WriteLine("==Learn2===");
    }

}