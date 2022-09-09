namespace ConsoleApp.Core;

class Operators
{

    public void Learn()
    {

        int a = 9;
        int b = 2;
        int c0 = a + b;
        int c1 = a - b;
        int c2 = a / b;
        double c3 = (double)a / b;

        Console.WriteLine(c0);
        Console.WriteLine(c1);
        Console.WriteLine(c2);
        Console.WriteLine(c3);
        Console.WriteLine(c3);

        double c4 = 9;
        double c5 = 2;
        double c6 = c4 / c5;
        Console.WriteLine(c6);

        double c7 = a % b;
        Console.WriteLine("modulo: {0}", c7);


        int a8 = ++a;
        Console.WriteLine("Pre ince: {0}", a8);
        Console.WriteLine("a {0}", a);

        int a9 = a++;
        Console.WriteLine("post incre: {0}", a9);
        Console.WriteLine("a {0}", a);

        int a10 = --a;
        Console.WriteLine("Pre dec: {0}", a10);
        Console.WriteLine("a: {0}", a);

        int a11 = a--;
        Console.WriteLine("post ince: {0}", a11);
        Console.WriteLine("a : {0}", a);

    }
}
