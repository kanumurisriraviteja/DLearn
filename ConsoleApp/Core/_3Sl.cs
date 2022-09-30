namespace ConsoleApp.Core;

static class _3Sl
{
    public static int a0 = 1;
    // int a1 = 2;   // Error > non static variables are not possible in static class

    static _3Sl()
    {
        Console.WriteLine("static constructor in Sl class");
    }


    // Error > constructor overloading with parameters is not possible
    //static _3Sl(int a)
    //{

    //}

    // Error -> static class can't have instance constructor
    //_3Sl()
    //{

    //}
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