namespace ConsoleApp.Core;

static class Sl
{
    public static int a0 = 1;
    // int a1 = 2;   // Error > non static variables are not possible in static class

    static Sl()
    {
        Console.WriteLine("static constructor in Sl class");
    }


    // Error > should have parameters
    // static Sl(int a)
    // {

    // }

    // Error -> static class can't have instance constructor
    // s1()
    // {

    // }
    public static void Learn()
    {
        int a1 = 2;
        Console.WriteLine(a1);
    }

    // Error > non static methods are not possible in static class
    // public void m2()
    // {

    // }
}