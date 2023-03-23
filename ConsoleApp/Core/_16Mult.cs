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
        t2.Join();
        // t3.Join(10); This is would wait only for 10 millisecond if not completed the next steps would be resumed
        t3.Join();
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
        for (int i = 0; i < 10; i++)
        {
            System.Console.WriteLine($"Learn1 {i}");
        }
        Console.WriteLine("Learn1");
        System.Console.WriteLine(Thread.CurrentThread.Name);
        //}

    }
    private void Learn2()
    {

        for (int i = 0; i < 100; i++)
        {
            System.Console.WriteLine($"Learn2 {i}");
        }
        System.Console.WriteLine(Thread.CurrentThread.Name);
        Console.WriteLine("Learn2");
    }
    private void Learn3()
    {

        for (int i = 0; i < 1000; i++)
        {
            System.Console.WriteLine($"Learn3 {i}");
        }
        Console.WriteLine("Learn3");
    }

    public async void LearnMt()
    {
        // SyncCall();
        ASyncCall();

    }
    private static async Task ASyncCall()
    {
        Console.WriteLine("ASyncCall=======Start");

        //scenario -1:
        _ = Task.Run(m1);
        _ = Task.Run(() => m2());
        await Task.Run(() => System.Console.WriteLine($"Learn5 called"));

        //scenario -2:
        Task t1 = Task.Run(m1);
        Task t2 = Task.Run(() => m2());
        await Task.Run(() => System.Console.WriteLine($"Learn5 called"));
        Task.WaitAll(t1, t2);  // this is the step that await for t1,t2

        //scenarion -3:
        // asawtLearn();
        await asawtLearn();  // if we dont await then the next steps is called before the completion of asawtLearn
        Console.WriteLine("ASyncCall=======End");
    }
    private void SyncCall()
    {
        int i1 = m1();
        int i2 = m2();
        int i3 = m3(i1, i2);
        System.Console.WriteLine(i3);
    }

    private static async Task asawtLearn()
    {
        System.Console.WriteLine("asawtLearn=======Start");
        await Task.Delay(1000);
        System.Console.WriteLine("m1-1== called");
        int i1 = m1();
        System.Console.WriteLine("m2-1== called");
        int i2 = m2();
        System.Console.WriteLine("m3-1== called");
        int i3 = m3(i1, i2);
        System.Console.WriteLine(i3);

        System.Console.WriteLine("m1-2== called");
        Task<int> t1 = Task.Run(m1);
        System.Console.WriteLine("m2-2== called");
        Task<int> t2 = Task.Run(m2);
        System.Console.WriteLine("m3-2== sc1 = called");
        Task.WaitAll(t1, t2);
        int i4_0 = m3(t1.Result, t2.Result);
        System.Console.WriteLine(i4_0);
        // await m3(t1.Result, t2.Result); //Error here m3 should be of task
        System.Console.WriteLine("m3-2== sc2 = called");
        int i4_1 = await m3Async(t1.Result, t2.Result);
        System.Console.WriteLine(i4_1);

        System.Console.WriteLine("m1-3== called");
        // int i5 = m1Async().GetAwaiter().GetResult(); // it will wait till the result is available
        Task<int> i5 = m1Async(); // next steps would be resumed 
        System.Console.WriteLine("m2-3== called");
        int i6 = m2Async().GetAwaiter().GetResult(); // it will wait till the result is available
        System.Console.WriteLine("m3-3== called");
        int i7 = await m3Async(i5.Result, i6);
        System.Console.WriteLine(i7);

        System.Console.WriteLine("asawtLearn=======End");

    }
    private static int m1()
    {
        Thread.Sleep(10000);
        Console.WriteLine("m1 is called");
        return 5;
    }
    private static int m2()
    {

        Console.WriteLine("m2 is called");
        return 15;
    }
    private static int m3(int a, int b)
    {
        Console.WriteLine("m3 is called");
        return a + b;
    }
    private static async Task<int> m1Async()
    {
        await Task.Delay(10000);
        Console.WriteLine("m1 is called");
        return 5;
    }
    private static async Task<int> m2Async()
    {
        Console.WriteLine("m2 is called");
        return 15;
    }
    private static async Task<int> m3Async(int a, int b)
    {
        Console.WriteLine("m3 is called");
        int resut = a + b;
        return resut;
    }

}