using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YVDB.Models;

namespace YVDB.Repos.Data
{
    public sealed class CustomerData
    {
        private static CustomerData instance = null;
        private static readonly object padlock = new object();

        private List<CustomerDTO> _cust = new List<CustomerDTO>();
        private static IDictionary<int, double>? _intrestRate;
        private CustomerData()
        {
            _cust.Add(new CustomerDTO()
            {
                CustomerId = 1,
                Name = "A",
                Address = new List<Address>() { new Address() { HNo = "1", State = "Telanga", Type = AddType.Temporary }, new Address() { HNo = "2", State = "AP", Type = AddType.Permanent } },
                Aadhar = 123,
                Age = 10,
                accountType = AccountType.Savings,
                phoneNo = 123,
                Password = "Test1",
                Balance = 10000
            });
            _cust.Add(new CustomerDTO()
            {
                CustomerId = 2,
                Name = "B",
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

        public List<CustomerDTO> GetCustomers()
        {
            return _cust;
        }
        public static CustomerData Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new CustomerData();
                    }
                    return instance;
                }
            }
        }
    }
}
