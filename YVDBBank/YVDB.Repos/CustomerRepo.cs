using System;
using YVDB.Models;
using YVDB.Repos.IRepos;

namespace YVDB.Repos;

public class CustomerRepo : ICustomerRepoRBI
{
    private static IDictionary<int, double> _intrestRate;
    private List<Customer> _cust = new List<Customer>();
    public CustomerRepo()
    {
        _cust.Add(new Customer()
        {
            CustomerId = 1,
            Name = "Yag",
            Address = new List<Address>() { new Address() { HNo = "1", State = "Telanga", Type = AddType.Temporary }, new Address() { HNo = "2", State = "AP", Type = AddType.Permanent } },
            Aadhar = 123,
            Age = 10,
            accountType = AccountType.Savings,
            phoneNo = 123,
            Password = "Test1",
            Balance = 10000
        });
        _cust.Add(new Customer()
        {
            CustomerId = 2,
            Name = "Venkat",
            Address = new List<Address>() { new Address() { HNo = "1", State = "Telanga", Type = AddType.Temporary }, new Address() { HNo = "2", State = "AP", Type = AddType.Permanent } },
            Aadhar = 123,
            Age = 30,
            accountType = AccountType.Savings,
            phoneNo = 123,
            Password = "Test1",
            Balance = 10000
        });

        _intrestRate = new Dictionary<int, double>();
        _intrestRate.Add((int)AccountType.Savings, 3.5);
        _intrestRate.Add((int)AccountType.Current, 0);
        _intrestRate.Add((int)AccountType.Salary, 3.5);
        _intrestRate.Add((int)AccountType.Senior, 4);

    }
    public void AddCustomer(Customer customer)
    {
        customer.CustomerId = (_cust.MaxBy(x => x.CustomerId) ?? new Customer() { CustomerId = 0 }).CustomerId + 1;
        _cust.Add(customer);
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
    public List<Customer> GiveCustomers()
    {
        return _cust;
    }

    public void ChangePassword(Customer c)
    {
        Customer customer = _cust.Find(x => x.CustomerId == c.CustomerId) ?? new Customer() { };
        customer.Password = c.Password;

    }

    public bool IsValidUser(Customer c)
    {
        Customer customer = _cust.Find(x => x.CustomerId == c.CustomerId) ?? new Customer() { Password = "" };
        bool isvalid = customer.Password == c.Password;
        return isvalid;

    }
}
