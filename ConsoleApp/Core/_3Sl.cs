namespace ConsoleApp.Core;

static class _3Sl
{
    public static int a0 = 1;
    // int a1 = 2;   // Error > non static variables are not possible in static class

    static _3Sl()
    {
        Console.WriteLine("static constructor in Sl class");
    }


    // Error > constructor overloading with parameters is not possible
    //static _3Sl(int a)
    //{

    //}

    // Error -> static class can't have instance constructor
    // _3Sl()
    // {

    // }
    public static void Learn()
    {

        // Error -> static variables are defined at the class level
        //static int d = 10;
        int a1 = 2;
        Console.WriteLine(a1);
    }

    // Error > non static methods are not possible in static class
    // public void m2()
    // {

    // }

    // this is a extension method for zeros.
    public static int Countzeros(this int t)
    {
        int number = 1020405;
        int count = 0;

        while (number != 0)
        {
            if (number % 10 == 0)
            {
                count++;
            }
            number /= 10;
        }

       return count;
    }
    // this is a extension method for the string type in the static class
    public static int CountVowels(this string t, string value)
    {
        string myStr;
        int i, len, vowel_count, cons_count;
        myStr = value;
        vowel_count = 0;
        cons_count = 0;
        // find length
        len = myStr.Length;
        for (i = 0; i < len; i++)
        {
            if (myStr[i] == 'a' || myStr[i] == 'e' || myStr[i] == 'i' || myStr[i] == 'o' || myStr[i] == 'u' || myStr[i] == 'A' || myStr[i] == 'E' || myStr[i] == 'I' || myStr[i] == 'O' || myStr[i] == 'U')
            {
                vowel_count++;
            }
            else
            {
                cons_count++;
            }
        }
        return vowel_count;
    }
}