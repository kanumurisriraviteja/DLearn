using ConsoleApp.Test;
using System.Text.RegularExpressions;

namespace ConsoleApp.Core;

public class _15Ex
{

    public void Learn()
    {
        try
        {
            Employee e = new Employee();
            e.Name = "teja123";
            ValidateName(e);
            Test();
            Console.WriteLine("This is logic");
            int[] a = new int[2];
            Console.WriteLine(a[5]);

        }
        catch (NameException ex)
        {
            Console.WriteLine("Name is not present" + ex);
            //throw ex;
        }
        catch (NullReferenceException e)
        {
            Console.WriteLine("This is null exception");
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("This is array exception");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("This is finally block");
        }


        Test1();
    }

    public void Test()
    {

        try
        {
            string s1 = null;
            Console.WriteLine(s1.IndexOf('a'));
        }
        catch (Exception e)
        {
            throw e;
            //Console.WriteLine("this is a exception in test");
        }
    }


    public void Test1()
    {
        Console.WriteLine("This is test1");
    }

    private static void ValidateName(Employee std)
    {
        string name = "kanumuri sri ravi teja";
        if (!name.Contains(std.Name))
            throw new NameException(std.Name);

    }


    // creating custom exception

    [Serializable]
    class NameException : Exception
    {
        public NameException(string msg) : base(msg)
        {

        }
    }

}