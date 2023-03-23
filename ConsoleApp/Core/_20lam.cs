using System.Collections;
using System.Linq;

namespace ConsoleApp.Core;

class _20lam
{
    public void Learn()
    {
        List<int> l1 = new List<int>() { 11, 12, 3, 4, 5 };

        // Traditional way of filtering without lambda
        List<int> l3 = TestL(l1);
        foreach (int item in l3)
        {
            System.Console.WriteLine(item);
        }

        List<int> l4 = l1.FindAll(x => x % 2 == 0);  // FindAll returns a new list  
        IEnumerable<int> l5 = l1.Where(x => x % 2 == 0); // where returns the same list and is lazy loaded
        List<int> l6 = l1.Select(x => x * x).ToList<int>();
        List<int> l7 = l1.Select(item => item % 2 == 0 ? item * 5 : item * 10).ToList(); // conditional operator
        List<int> l8 = l1.Select(item =>
                                {
                                    if (item % 2 == 0)
                                    {
                                        return item * 5;
                                    }
                                    else
                                    {
                                        return item * 10;
                                    }
                                }).ToList();

        Func<int, string> f1 = x => x > 0 ? "positive" : x < 0 ? "negative" : "zero";
        System.Console.WriteLine(f1(1));

    }

    public static List<int> TestL(List<int> l2)
    {
        List<int> l3 = new List<int>();

        foreach (int i in l2)
        {
            if (i % 2 == 0)
                l3.Add(i);
        }
        return l3;
    }
}