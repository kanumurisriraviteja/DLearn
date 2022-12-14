using ConsoleApp.Core;
namespace ConsoleApp.Test;

public class UsrTwo : _4Nsl
{

    /*
      This method helps to learn use of variables
    */
    public void Learn()
    {

        // access the non static variables /methods
        _4Nsl u2 = new _4Nsl();
        Console.WriteLine(u2.a1);
        u2.a1 = u2.a1 + 1;
        Console.WriteLine(u2.a1);


        // accessing the static varaibles
        Console.WriteLine(_4Nsl.a0);
        _4Nsl.a0 = _4Nsl.a0 + 20;
        Console.WriteLine(_4Nsl.a0);

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

// // Error private class is not possible
// private class UserThree 
// {

// }

// // Error protected class is not possible
// protected class UserFour
// {


// }

// This is known as internal class
class UserFive
{

}