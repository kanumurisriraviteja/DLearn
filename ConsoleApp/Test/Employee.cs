using ConsoleApp.Core;
namespace ConsoleApp.Test;

public class Employee
{
    private int Id;

    public int EmployyeId
    {
        get { return Id; }
        set
        {
            if (value < 0)
            {
                Id = 0;
            }
            else { Id = value; }

        }
    }

    public string Name { get; set; }
    public float Salary { get; set; }
}