using ConsoleApp.Core;
namespace ConsoleApp.Test;

public partial class Employee 
{
    private int Id;

    public int EmployyeId
    {
        get { return Id; }
        set
        {
            if (value < 0)
            {
                this.Id = 0;
            }
            else { this.Id = value; }

        }
    }

    public string Name { get; set; }
    public float Salary { get; set; }
    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        Employee objAsPart = obj as Employee;
        if (objAsPart == null) return false;
        else return Equals(objAsPart);
    }
    public bool Equals(Employee other)
    {
        if (other == null) return false;
        return (this.Id.Equals(other.EmployyeId));
    }

    
}