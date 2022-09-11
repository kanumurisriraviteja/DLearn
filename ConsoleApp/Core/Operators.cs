namespace ConsoleApp.Core;

class Operators
{

    public void Learn()
    {
        // Arithmetic Operators -- start
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
        //Arithmetic Operators -- end

        // Relational Operators -- start

        bool c = true;
        string d = "test";
        float e = 10.5f;
        double f = 55.44d;
        if (a == f) { Console.WriteLine("Equal"); }  //valid
        if (a == e) { Console.WriteLine("Equal"); }  //valid
        // if (a == d) { Console.WriteLine("Equal"); }  //Error
        // if (a == d) { Console.WriteLine("Equal"); }  //Error
        // if (a <= c) { Console.WriteLine("Equal"); } // Error
        Console.WriteLine("NOt Equal");
        // Relational Operators -- end


        // Logical OPerator -- start
        if (10 / 2 == 5 && 10 / 3 == 3 && 10 / 7 == 1)
        {
            Console.WriteLine("Local AND");
        }

        if (10 / 2 == 5 || 10 / 8 == 3 && 10 / 6 == 1)
        {
            Console.WriteLine("Local AND");
        }

        // Logical OPerator -- end

        Console.WriteLine(30 << 7);
        Console.WriteLine(30 >> 2);

        // BODMAS rule    -- Arithmatic Operators
        Console.WriteLine(6 / 2 + 1);
    }
}