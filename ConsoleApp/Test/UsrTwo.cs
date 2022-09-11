using ConsoleApp.Core;
namespace ConsoleApp.Test;

public class UsrTwo
{

    /*
      This method helps to learn use of variables
    */
    public void Learn()
    {

        // access the non static variables /methods
        Nsl u2 = new Nsl();
        Console.WriteLine(u2.a1);
        u2.a1 = u2.a1 + 1;
        Console.WriteLine(u2.a1);


        // accessing the static varaibles
        Console.WriteLine(Nsl.a0);
        Nsl.a0 = Nsl.a0 + 20;
        Console.WriteLine(Nsl.a0);

    }
}