using System;
using YVDB.Models;
using YVDB.Repos.Data;
using YVDB.Repos.IRepos;

namespace YVDB.Repos;

public class CustomerRepo : ICustomerRepoRBI
{
    private static IDictionary<int, double> _intrestRate;
    private List<CustomerDTO> _cust = new List<CustomerDTO>();

    public CustomerData CustomerData { get; }

    public CustomerRepo()
    {
        CustomerData = CustomerData.Instance;
        _cust = CustomerData.GetCustomers();

    }

    public override void AddBalance(int CustomerId, double Balance)
    {
        CustomerDTO customer = _cust.Find(x => x.CustomerId == CustomerId) ?? new CustomerDTO() { };
        customer.Balance += Balance;

    }

    public override void WithDrawBalance(int CustomerId, double Balance)
    {
        CustomerDTO customer = _cust.Find(x => x.CustomerId == CustomerId) ?? new CustomerDTO() { };
        customer.Balance -= Balance;
    }
    public override double ShowBalance(int CustomerId)
    {
        CustomerDTO customer = _cust.Find(x => x.CustomerId == CustomerId) ?? new CustomerDTO() { };
        return customer.Balance;
    }


    public void ChangePassword(CustomerDTO c)
    {
        CustomerDTO customer = _cust.Find(x => x.CustomerId == c.CustomerId) ?? new CustomerDTO() { };
        customer.Password = c.Password;

    }

    public bool IsValidCustomer(CustomerDTO c)
    {
        CustomerDTO customer = _cust.Find(x => x.CustomerId == c.CustomerId) ?? new CustomerDTO() { Password = "" };
        bool isvalid = customer.Password == c.Password;
        return isvalid;

    }
}
