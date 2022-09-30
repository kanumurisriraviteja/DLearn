using System.Text.RegularExpressions;

namespace ConsoleApp.Core;

public class _15Ex
{

    public void Learn()
    {
        try
        {
            Student newStudent = null;
            newStudent = new Student();
            newStudent.StudentName = "James";
            ValidateStudent(newStudent);
            Test();
            Console.WriteLine("This is logic");
            int[] a = new int[2];
            Console.WriteLine(a[5]);

        }
        catch (InvalidStudentNameException ex)
        {
            Console.WriteLine(ex.Message);
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


    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
       
    }

    [Serializable]
    class InvalidStudentNameException : Exception
    {
        public InvalidStudentNameException() { }

        public InvalidStudentNameException(string name)
            : base(String.Format("Invalid Student Name: {0}", name))
        {

        }
    }

    private static void ValidateStudent(Student std)
    {
        Regex regex = new Regex("^[a-zA-Z]+$");

        if (!regex.IsMatch(std.StudentName))
            throw new InvalidStudentNameException(std.StudentName);

    }

}