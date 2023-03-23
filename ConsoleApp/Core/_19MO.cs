namespace ConsoleApp.Core;

class _19MO
{
    public static void Learn()
    {
        Add(5, 5, 4);
        Add(5, 5, 5);
        // if exact match and optional match is available then only the exact match is executed.

    }

    public static double Add(float a, int b, int c)
    {
        System.Console.WriteLine("1 is executed");
        return a + b;
    }

    public static float Add(int a, int b, int c)
    {
        System.Console.WriteLine("2 is executed");
        Console.WriteLine(a + b + c);
        return a + b + c;
    }

    public static float Add(int a, int b)
    {
        System.Console.WriteLine("3 is executed");
        return a + b;
    }

    public static float Add(int a, int b, int c, int d = 1)
    {
        System.Console.WriteLine("4 is executed");
        return a + b;
    }

}