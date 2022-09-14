using ConsoleApp.Core;
namespace ConsoleApp.Test;

public class UsrTwo : Nsl
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

        // u2.a2; // Error private variables are not accessable
        // u2.Learn2(); // Error private method is not accessable  outside the class


        // Public variables, method -- No Restriction
        Console.WriteLine(u2.a1);
        u2.Learn1();

        Console.WriteLine(a3); //Inherited variables are accessable as it is inherited
        Learn3(); //  Inherited methods are accessable

        Console.WriteLine(u2.a4); //No Restriction
        u2.Learn4(); //No Restriction

    }



}