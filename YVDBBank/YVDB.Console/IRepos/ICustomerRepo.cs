namespace YVDB.Console.IRepos;

public interface ICustomerRepoWorld
{
    void AddBalance();
    void WithDrawBalance();
}

public abstract class ICustomerRepoRBI : ICustomerRepoWorld
{
    public abstract void AddBalance();
    public abstract void WithDrawBalance();
    public abstract void DebitCard();

    public int UPIPayments(int phoneNo)
    {
        if (phoneNo > 0)
        {
            return 10;
        }
        return 0;
    }
}