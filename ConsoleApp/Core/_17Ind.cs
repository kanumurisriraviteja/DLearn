using ConsoleApp.Test;
namespace ConsoleApp.Core;


public class _17Ind
{
    private string[] ar = new string[3];  // Accessing a private variable via a public method
    private string[] val = new string[3];  // Accessing a private variable via a public method

    private List<Employee> l2;
    public string getData(int i)
    {
        return ar[i];
    }
    public void setData(int i, string val)
    {
        ar[i] = val;
    }

    public string this[int index]
    {
        get
        {
            return val[index];
        }
        set
        {
            val[index] = value;
        }
    }

    public string[] valuearr = new string[3];

    public _17Ind()
    {
        l2 = new List<Employee>();
        l2.Add(new Employee() { EmployyeId = 1, Name = "Sri", Salary = 30 });
        l2.Add(new Employee() { EmployyeId = 2, Name = "Ravi", Salary = 10 });
        l2.Add(new Employee() { EmployyeId = 3, Name = "Teja", Salary = 20 });
        l2.Add(new Employee() { EmployyeId = 4, Name = "Kanumuri", Salary = 30,JobTitle ="sw" });

    }


    public float getEmpSal(int eId, string eName) 
    {
        return l2.FirstOrDefault(x => x.EmployyeId == eId && x.Name == eName).Salary;
    }

    // Use "this" keyword to create an indexer
    // This indexer takes employeeId, employeeName as parameter
    // and returns salary
    public float this[int eId, string employeeName]
    {
        // Just like properties indexers have get and set accessors
        get
        {
            return l2.FirstOrDefault(x => x.Name == employeeName && x.EmployyeId == eId).Salary;
        }
        set
        {
            l2.FirstOrDefault(x => x.Name == employeeName && x.EmployyeId == eId).Salary = value;
        }
    }
}