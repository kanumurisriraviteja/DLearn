namespace ConsoleApp.Core;

public class _12oopsbase
{
    public int a0 = 10;
    private int a1 = 20;

    public _12oopsbase()
    {
        Console.WriteLine("This is constructor in _12oopsbase class:");
    }

    public void m1()
    {
        Console.WriteLine("This is m1 method in _12oopsbase class:" + a0);
    }

    public virtual void m3()
    {
        Console.WriteLine("This is m3 method in _12oopsbase class");
    }

    public virtual void m4()
    {
        Console.WriteLine("This is m4 method in _12oopsbase class");
    }

    public void m5()
    {
        Console.WriteLine("This is m5 method in _12oopsbase class");
    }

    public void m6()
    {
        Console.WriteLine("This is m6 method in _12oopsbase class");
    }

}

public class TestOne : _12oopsbase
{
    public TestOne()
    {
        Console.WriteLine("This is constructor in TestOne class:");
    }


    public int a2 = 30;
    public void m2()
    {
        Console.WriteLine("This is m2 method in Testone class:" + a0);
        // Console.WriteLine("This is m2 method in Testone class:" + a1); // cant be accesed
    }

    public override void m3()
    {
        base.m3();
        // m3(); base.m3() and m3() are one and the same
        // m3(); base.m3() and m3() are one and the same
    }


    public override void m4()
    {
        Console.WriteLine("This is m4 method in Testone class");
    }

    public new void m5()
    {
        Console.WriteLine("This is m5 method in Testone class");
    }

    public void m6()
    {
        Console.WriteLine("This is m6 method in Testone class");
    }
}

public class TestTwo
{
    public void m2()
    {

        // Console.WriteLine(a); // Error can be accessed
    }

}

public class TestThree : TestOne
{

}

// Mutiple inheritence is not possible in c#
// public class TestThree : TestOne , TestTwo
// {

// }

public class TestFour : TestTwo, _10IntLearn, _10IntLearnTwo
{
    public void AddBalance()
    {
        throw new NotImplementedException();
    }

    public void DebitCard()
    {
        throw new NotImplementedException();
    }

    public void WithBalance()
    {
        throw new NotImplementedException();
    }

    public void EMICard()
    {
        throw new NotImplementedException();
    }

    public void SavingAccount()
    {
        throw new NotImplementedException();
    }
}