namespace ConsoleApp.Core;

class _2DataType
{
    int ic;
 

    public void Learn()
    {

        // value data types  -- start 

        int i, j = 10, k = 100;  // Assign in the same line
        // Console.WriteLine(i); // Error i can't be assigned as it is not assigned
        Console.WriteLine($"class level initialized default int variable {ic}");  // class level variables would be initialized by the constructor

        // Implicit Type casting >> lower datatype to higher data type
        byte a0 = 250;
        int b0 = a0;
        Console.WriteLine(a0);
        Console.WriteLine(b0);
        Console.WriteLine(sizeof(int));
        Console.WriteLine(sizeof(float));
        System.Type type = typeof(int);
        Console.WriteLine(type);

        // Explicit Type casting >> higher datatype to lower data type
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


        // value assignmet and re-assignment
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
        // for var the memory allocation is at the compile time
        var a5 = 1;
        var b5 = 'Y';
        Console.WriteLine(a5);
        Console.WriteLine(b5);

        // for dynamic the memory allocation is at the run time
        dynamic a6 = 2;
        dynamic b6 = "yessss";

        string b4 = "yes";
        Console.WriteLine(b4);

        // Object
        object obj = 10;
        object obj1 = "test";
        object obj2 = new Object();

        // Reference Data type -- end 



        // Nullable datatypes
        int? i0 = 10;
        //int i1 = null;  // Error
        int? i2 = null;
        Nullable<int> i3 = null;

        // HasValue check if we have value or not
        if (i3.HasValue)
            Console.WriteLine(i3.Value);


        string? s1 = null;
        string? s2 = null;
        //s1.ToLower(); Error Null Reference Exception

        double? num1 = null;
        double num3;
        num3 = num1 ?? 5.34;
        if (num1 == null)
            num3 = 5.34;
        else
            num3 = (double)num1;

    }

}