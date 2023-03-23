using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp.Core;
public struct _13stru
{
    int i1;

    public void Learn()
    {

    }

}
// struct can't be inherited from another struc
// struct Test : _13stru
// {

// }


struct Test : _10IntLearn
{
    public override bool Equals([NotNullWhen(true)] object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string? ToString()
    {
        return base.ToString();
    }

    void _10IntLearn.AddBalance()
    {
        throw new NotImplementedException();
    }

    void _10IntLearn.DebitCard()
    {
        throw new NotImplementedException();
    }

    void _10IntLearn.SavingAccount()
    {
        throw new NotImplementedException();
    }

    void _10IntLearn.WithBalance()
    {
        throw new NotImplementedException();
    }
}