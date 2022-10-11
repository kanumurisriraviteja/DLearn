using System.Diagnostics;
using System.Threading;


namespace ConsoleApp.Core;


public class _16Mult
{
    object o1 = new Object();
    public void Learn()
    {
        Stopwatch s1 = new Stopwatch();
        s1.Start();
        Learn1();
        Learn2();
        Learn3();
        s1.Stop();
        Console.WriteLine("Processing time is " + s1.ElapsedMilliseconds);


        Thread.Sleep(1000);

        Console.WriteLine("==============================================" + Thread.CurrentThread.Name);
        Stopwatch s2 = new Stopwatch();
        s2.Start();
        Thread t1 = new Thread(Learn1);
        t1.Name = "This is thread1";
        t1.Priority = ThreadPriority.Highest;

        Thread t4 = new Thread(Learn1);
        Thread t2 = new Thread(Learn2);
        t2.Priority = ThreadPriority.AboveNormal;
        if (!t1.IsAlive)
            t2.Priority = ThreadPriority.Highest;
        Thread t3 = new Thread(Learn3);

        t1.Start();
        t2.Start();
        t3.Start();
        t4.Start();

        t1.Join();
        t2.Join(10);
        t3.Join(10);
        t4.Join();
        s2.Stop();

        System.Console.WriteLine("============================main exit");
        Console.WriteLine("Processing time is " + s2.ElapsedMilliseconds);

    }
    private void Learn1()
    {
        //lock (o1)
        //{
        //Thread.Sleep(1000);
        for (int i = 0; i < 10000; i++)
        {
            System.Console.WriteLine($"Learn1 {i}");
        }
        Console.WriteLine("Learn1");
        System.Console.WriteLine(Thread.CurrentThread.Name);
        //}

    }
    private void Learn2()
    {

        for (int i = 0; i < 1000; i++)
        {
            System.Console.WriteLine($"Learn2 {i}");
        }
        System.Console.WriteLine(Thread.CurrentThread.Name);
        Console.WriteLine("Learn2");
    }
    private void Learn3()
    {

        for (int i = 0; i < 1000000000; i++)
        {
            //System.Console.WriteLine($"Learn3 {i}");
        }
        Console.WriteLine("Learn3");
    }

    public void Learn4()
    {
        Learn5();
    }

    private async void Learn5()
    {
        //for (int i = 0; i < 100; i++)
        //{

        Learn1();
        Learn2();
        _ = Task.Run(Learn1);
        Task.Run(() => Learn2());

        await Task.Run(() => System.Console.WriteLine($"Learn5 called"));
        //}
        Console.WriteLine("Learn5");
    }

    private void Learn6()
    {

        for (int i = 0; i < 100; i++)
        {
            System.Console.WriteLine($"Learn1 {i}");
        }
        Console.WriteLine("Learn1");
    }



    private bool isEven(int a) 
    { 
  
        return a% 2 == 0;
    }
}