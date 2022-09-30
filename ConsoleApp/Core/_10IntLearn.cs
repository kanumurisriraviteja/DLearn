namespace ConsoleApp.Core;

public interface _10IntLearn
{
    public static int iVar = 500;
    // int i1; // interfaces cannot have non static members

    void AddBalance(); // if we dont declare anything then its public

    void WithBalance();

    void DebitCard();

    void SavingAccount();
}

interface _10IntLearnTwo
{
    void EMICard();
}