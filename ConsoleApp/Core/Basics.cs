namespace ConsoleApp.Core;

public class Basics
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

        string input = Console.ReadLine();
        int a0 = Convert.ToInt32(input);
        Console.WriteLine("The data entered by the user is {0}", a0);
    }

}