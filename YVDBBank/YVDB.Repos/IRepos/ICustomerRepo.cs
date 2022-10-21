namespace YVDB.Repos.IRepos;

public interface ICustomerRepoWorld
{
    void AddBalance(int customerId, double Balance);
    void WithDrawBalance(int customerId, double Balance);
}

public abstract class ICustomerRepoRBI : ICustomerRepoWorld
{
    public abstract void AddBalance(int customerId, double Balance);
    public abstract void WithDrawBalance(int customerId, double Balance);
    public abstract double ShowBalance(int customerId);


    public int UPIPayments(int phoneNo)
    {
        if (phoneNo > 0)
        {
            return 10;
        }
        return 0;
    }
}