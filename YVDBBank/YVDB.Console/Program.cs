using YVDB.Console.Models;
using YVDB.Console.Repos;

internal class Program
{
    private readonly CustomerRepo r;
    public Program()
    {
        r = new CustomerRepo();
    }
    static void Main(string[] args)
    {
        Program p = new Program();
        p.Logic();

    }
    private void Logic()
    {
        string? opt;
        do
        {
            Console.WriteLine("Hi Welcome to YVDB Bank");
            Console.WriteLine("Choose the operation to Perform,1. Add Customer 2.Add Balance 3. Withdraw 4.UPI Transfer 5.show customers");
            int option = Convert.ToInt32(System.Console.ReadLine());

            switch (option)
            {
                case 1:
                    AddCustomer();
                    break;
                case 5:
                    ShowCustomers();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
            Console.WriteLine(" type y to contine");
            opt = Console.ReadLine();
        } while (opt == "y");
    }

    private void AddCustomer()
    {
        try
        {
            Customer c = new Customer();
            Console.WriteLine("Enter Your Name");
            c.Name = Console.ReadLine();
            Console.WriteLine("Enter Your Addrees Type 1 for Temporary, 2 for Permanent");
            int type = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("Enter Your H.NO");
            string? hno = Console.ReadLine();
            Console.WriteLine("Enter Your state");
            string? state = Console.ReadLine();
            if (type == 1)
            {
                c.Address = new List<Address> { new Address() { HNo = hno, Type = AddType.Temporary, State = state } };
            }
            else
            {
                c.Address = new List<Address> { new Address() { HNo = hno, Type = AddType.Permanent, State = state } };
            }

            Console.WriteLine("Enter Your Aadhar no");
            c.Aadhar = Convert.ToInt32(System.Console.ReadLine());

            Console.WriteLine("Enter Your Age");
            c.Age = Convert.ToInt32(System.Console.ReadLine());

            Console.WriteLine("Enter Your Account Type 1.Savings, 2.Current ,3.Salary, 4.Senior");
            int savingsType = Convert.ToInt32(System.Console.ReadLine());

            if (savingsType == 1)
            {
                c.accountType = AccountType.Savings;
            }
            else if (savingsType == 2)
            {
                c.accountType = AccountType.Current;
            }
            else if (savingsType == 3)
            {
                c.accountType = AccountType.Salary;
            }
            else if (savingsType == 4)
            {
                c.accountType = AccountType.Senior;
            }
            else
            {
                throw new Exception();
            }
            r.AddCustomer(c);
        }
        catch (Exception e)
        {
            Console.WriteLine("Account is not created" + e.Message);
        }
    }
    public void ShowCustomers()
    {
        List<Customer> c = r.GiveCustomers();

        foreach (var item in c)
        {
            Console.WriteLine($"Customer Id {item.CustomerId}, Name is {item.Name}, His balance is {item.Balance}");
        }
    }
}