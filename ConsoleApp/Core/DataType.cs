namespace ConsoleApp.Core;

class DataType
{

    public void Learn()
    {

        // value data types  -- start 
        // Implicit Type casting
        byte a0 = 250;
        int b0 = a0;
        Console.WriteLine(a0);
        Console.WriteLine(b0);
        Console.WriteLine(sizeof(int));
        Console.WriteLine(sizeof(float));
        System.Type type = typeof(int);
        Console.WriteLine(type);

        // Explicit Type casting
        int a1 = 250;
        byte b1 = (byte)a1;
        Console.WriteLine(a1);
        Console.WriteLine(b1);
        int a2 = 260;
        byte b2 = (byte)a2;
        Console.WriteLine(a2);
        Console.WriteLine(b2);


        double a3 = 1004.55;
        int b3 = (int)a3;
        Console.WriteLine(a3);
        Console.WriteLine(b3);

        char a4 = 'y';
        Console.WriteLine(a4);

        int a7;
        a7 = 10;
        Console.WriteLine(a7);
        int a8 = 11;
        Console.WriteLine(a8);
        a8 = 12;
        Console.Write(a8);

        const double a9 = 3.14;
        // a9 =10.5  --- Error const can't be reassigned
        Console.WriteLine(a9);

        // value data types  -- end


        // Reference Data type -- start 
        var a5 = 1;
        var b5 = 'Y';
        Console.WriteLine(a5);
        Console.WriteLine(b5);

        dynamic a6 = 2;
        dynamic b6 = "yessss";

        string b4 = "yes";
        Console.WriteLine(b4);
        object obj = 10;
        object obj1 = "test";
        object obj2 = new Object();

        // Reference Data type -- end 


    }

}