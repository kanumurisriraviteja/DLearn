using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Core;
public delegate int TestDel1(string s);
public delegate void TestDel2(string s);
public delegate bool TestDel3(string s);
public delegate void CallBackDel(int i);

class _18Del
{
    int[] a1 = { 1, 41, 44, 2, 647, 5, 42, 22, 24 };
    public void Learn()
    {
        DelLearn();
        DelImp();
        LongRunningDelegate(CallBackM);
        LongRunning(Enumerable.Range(1, 1000)).ToList().ForEach(p => System.Console.WriteLine(p));
    }

    private void DelLearn()
    {
        // Func Delegate
        int i1 = m1("test");
        TestDel1 testDel1 = new TestDel1(m1);
        testDel1("test");
        TestDel1 testDel1_1 = m1;
        testDel1_1("test");

        Func<string, int> func1 = m2;
        int i2 = func1("testy");

        Func<int, string> f1 = x => x > 0 ? "positive" : x < 0 ? "negative" : "zero";
        System.Console.WriteLine(f1(1));

        // Action Delegate
        m3("test");
        TestDel2 testDel2 = new TestDel2(m3);
        testDel2("test");

        Action<string> action = m3;
        action("test");


        //Predicate Delegate
        bool b1 = m4("test");
        TestDel3 testDel3 = new TestDel3(m4);
        testDel3("test");

        Predicate<string> p1 = m4;
        bool b2 = p1("test");

        Predicate<int> p2 = (x) =>
        {
            if (x % 2 == 0) return true;
            else return false;
        };
        Console.WriteLine(p2(100));
    }

    private int m1(string s)
    {
        System.Console.WriteLine(s);
        return 5;
    }
    private int m2(string s)
    {
        System.Console.WriteLine(s);
        return 5;
    }

    private void m3(string s)
    {
        System.Console.WriteLine(s);
    }

    private bool m4(string s)
    {
        System.Console.WriteLine(s);
        return true;
    }

    private void DelImp()
    {
        System.Console.WriteLine("No greater than 5");
        m5(a1, greaterthan).ForEach(p => Console.Write($" {p}"));
        System.Console.WriteLine("");
        System.Console.WriteLine("even no");
        m5(a1, x => x % 2 == 0).ForEach(p => Console.Write($" {p}"));
        System.Console.WriteLine("");
        System.Console.WriteLine("No less than 10");
        m5(a1, x => x < 10).ForEach(p => Console.Write($" {p}"));
        System.Console.WriteLine("");
    }

    public bool greaterthan(int i1)
    {
        return i1 > 5;
    }
    private List<int> m5(IEnumerable<int> ie, Predicate<int> p)
    {
        List<int> l1 = new List<int>();
        foreach (int i in ie)
        {
            if (p(i))
                l1.Add(i);
        }
        return l1;
    }

    private void LongRunningDelegate(CallBackDel obj)
    {
        for (int i = 0; i < 5; i++)
        {
            obj(i);
        }
    }
    private void CallBackM(int i)
    {
        Console.WriteLine(i);
    }

    private IEnumerable<int> LongRunning(IEnumerable<int> ien)
    {
        foreach (int i in ien)
        {
            yield return i * i;
        }
    }
}