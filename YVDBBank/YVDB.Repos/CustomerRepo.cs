using System;
using YVDB.Models;
using YVDB.Repos.Data;
using YVDB.Repos.IRepos;

namespace YVDB.Repos;

public class CustomerRepo : ICustomerRepoRBI
{
    private static IDictionary<int, double> _intrestRate;
    private List<Customer> _cust = new List<Customer>();

    public CustomerData CustomerData { get; }

    public CustomerRepo()
    {
        CustomerData = CustomerData.Instance;
        _cust = CustomerData.GetCustomers();

    }

    public override void AddBalance(int CustomerId, double Balance)
    {
        Customer customer = _cust.Find(x => x.CustomerId == CustomerId) ?? new Customer() { };
        customer.Balance += Balance;

    }

    public override void WithDrawBalance(int CustomerId, double Balance)
    {
        Customer customer = _cust.Find(x => x.CustomerId == CustomerId) ?? new Customer() { };
        customer.Balance -= Balance;
    }
    public override double ShowBalance(int CustomerId)
    {
        Customer customer = _cust.Find(x => x.CustomerId == CustomerId) ?? new Customer() { };
        return customer.Balance;
    }


    public void ChangePassword(Customer c)
    {
        Customer customer = _cust.Find(x => x.CustomerId == c.CustomerId) ?? new Customer() { };
        customer.Password = c.Password;

    }

    public bool IsValidCustomer(Customer c)
    {
        Customer customer = _cust.Find(x => x.CustomerId == c.CustomerId) ?? new Customer() { Password = "" };
        bool isvalid = customer.Password == c.Password;
        return isvalid;

    }
}
