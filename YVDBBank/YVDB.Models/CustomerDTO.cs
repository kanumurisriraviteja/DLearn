using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace YVDB.Models;

public class CustomerDTO
{
    public int CustomerId { get; set; }
    public string? Name { get; set; }

    //public List<string> Address { get; set; }
    public List<Address>? Address { get; set; }
    public int? AccType { get; set; }

    public double Aadhar { get; set; }

    private int _Age;
    public int Age
    {
        get
        {
            return _Age;
        }
        set
        {
            if (value > 18)
                _Age = value;
            else
            {
                _Age = 18;
            }
        }
    }

    //private double _Balance = 10000;
    //public double Balance
    //{
    //    get { return _Balance; }
    //    set
    //    {
    //        if (this.accountType == AccountType.Salary)
    //        {
    //            if (_Balance - value >= 0)
    //            {
    //                _Balance += value;
    //            }
    //        }
    //        else
    //        {
    //            if (_Balance - value > 10000)
    //            {
    //                _Balance += value;
    //            }
    //        }
    //    }

    //}
    public double Balance { get; set; }
    public double phoneNo { get; set; }
    public AccountType accountType { get; set; }
    public string? Password { get; set; }
}
public class Address
{
    public string? HNo { get; set; }
    public string? State { get; set; }
    //public string Type { get; set; }
    public AddType Type { get; set; }
}
public enum AddType
{
    Permanent, Temporary
}
public enum AccountType
{
    Savings, Current, Salary, Senior
}
