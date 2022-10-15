using System;
using YVDB.Console.Models;
using YVDB.Console.IRepos;

namespace YVDB.Console.Repos;

public class CustomerRepo : ICustomerRepoRBI
{
    private IDictionary<int, double> _intrestRate;
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
            phoneNo = 123

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

    public override void AddBalance()
    {

        throw new NotImplementedException();
    }

    public override void WithDrawBalance()
    {
        throw new NotImplementedException();
    }
    public override void DebitCard()
    {
        throw new NotImplementedException();
    }

    public List<Customer> GiveCustomers()
    {
        return _cust;
    }
}
