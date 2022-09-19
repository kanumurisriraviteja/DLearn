using ConsoleApp.Core;
namespace ConsoleApp.Test;

public class UsrOne
{
    public void Learn()
    {

        // access the non static variables /methods
        _4Nsl u1 = new _4Nsl();
        Console.WriteLine(u1.a1);
        u1.a1 = u1.a1 + 1;
        Console.WriteLine(u1.a1);
        u1.Learn1();

        // accessing the static varaibles
        Console.WriteLine(_4Nsl.a0);
        _4Nsl.a0 = _4Nsl.a0 + 10;
        Console.WriteLine(_4Nsl.a0);

        // u1.a2; // Error private variables are not accessable
        // u1.Learn2(); // Error private method is not accessable  outside the class


        // Public variables, method -- No Restriction
        Console.WriteLine(u1.a1);
        u1.Learn1();

        //  u1.a3; // Error Inherited variables are not accessable
        // u1.Learn3(); // Error Inherited variables are not accessable

        Console.WriteLine(u1.a4); //No Restriction
        u1.Learn4(); //No Restriction


    }
}