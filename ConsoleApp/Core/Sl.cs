namespace ConsoleApp.Core;

static class Sl
{
    static int a0 = 1;
    // int a1 = 2;   // Error > non static variables are not possible in static class
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