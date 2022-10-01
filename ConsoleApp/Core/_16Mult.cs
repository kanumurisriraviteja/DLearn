using System.Diagnostics;

namespace ConsoleApp.Core;


public class _16Mult
{

    public void Learn()
    {
        Stopwatch s1 = new Stopwatch();
        s1.Start();
        Learn1();
        Learn2();
        Learn3();
        s1.Stop();
        Console.WriteLine("Processing time is " + s1.ElapsedMilliseconds);

        Console.WriteLine("==============================================");
        Stopwatch s2 = new Stopwatch();
        s2.Start();
        Thread t1 = new Thread(Learn1);
        Thread t2 = new Thread(Learn2);
        Thread t3 = new Thread(Learn3);

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();
        s2.Stop();
        Console.WriteLine("Processing time is " + s2.ElapsedMilliseconds);

    }


    private void Learn1()
    {
        for (int i = 0; i < 1000000000; i++)
        {
            //System.Console.WriteLine($"Learn1 {i}");
        }
    }

    private void Learn2()
    {
        for (int i = 0; i < 1000000000; i++)
        {
            //System.Console.WriteLine($"Learn2 {i}");
        }
    }

    private void Learn3()
    {
        for (int i = 0; i < 1000000000; i++)
        {
            //System.Console.WriteLine($"Learn3 {i}");
        }

    }

}