namespace ConsoleApp.Core;

public class _1Basics
{

    public void BL()
    {

        //  Output
        /*
        1
        23
        4
        */
        Console.WriteLine("1");
        Console.Write("2");
        Console.WriteLine("3");
        Console.Write("4");


        // How to read from console
        string input = Console.ReadLine();
        int a0 = Convert.ToInt32(input);
        Console.WriteLine("The data entered by the user is {0}", a0);
    }

}