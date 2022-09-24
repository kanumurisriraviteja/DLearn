using ConsoleApp.Test;
using System.Collections;

namespace ConsoleApp.Core;

class _9DatastrLearn
{
    public void Learn()
    {
        //ArrayLearn();
        //ArrayListLearn();
        //ListLearn();
        //EQCLearn();
        //HashSetLearn();
        //HashTableDictLearn();
        // SQLearn();
    }

    private void ArrayLearn()
    {
        oneDArray();
        // twoDArrary();
        // JaggedArrary();
    }
    private void oneDArray()
    {
        // 1-D int arrary 
        // int[]  i0 = new int[]; // Error
        int[] i0 = new int[10];
        i0[0] = 41;
        i0[1] = 31;
        //i0[10] = 55; // Runtime IndexOutOfRangeException

        int[] i1 = new int[] { 41, 31 };
        int[] i2 = i1;
        i2[0] = 51;
        Console.WriteLine($"the element in i1 -0 location  is {i1[0]}");
        Console.WriteLine($"the element in i2 -0 location  is  {i2[0]}");

        // If we take a clone of the memory then it would create a new copy
        int[] i3 = i1.Clone() as int[];
        i3[0] = 61;
        Console.WriteLine($"the element in i1 -0 location  is {i1[0]}");
        Console.WriteLine($"the element in i2 -0 location  is  {i2[0]}");
        Console.WriteLine($"the element in i3 -0 location  is  {i3[0]}");


        int[] i4 = { 1, 2, 3 };

        Console.WriteLine("Arrary for loop");
        for (int i = 0; i < i0.Length; i++)
        {
            Console.WriteLine(i0[i]);
        }

        Console.WriteLine("Arrary foreach loop");
        foreach (int i in i0)
        {
            Console.WriteLine(i);
        }

        //Error Arrary  System.IndexOutOfRangeException
        //for (int i = 0; i <= i0.Length + 5; i++) 
        //{
        //    Console.WriteLine(i0[i]);
        //}


        Employee e1 = new Employee();
        e1.EmployyeId = 1;
        e1.Name = "Yag";
        e1.Salary = 5;
        Employee e2 = new Employee() { EmployyeId = 2, Name = "Durga", Salary = 6 };


        Employee[] e3 = new Employee[2];
        e3[0] = e1;
        e3[1] = e2;

        Employee[] e4 = new Employee[] { e1, e2 };

        foreach (var item in e4)
        {
            Console.WriteLine($"Employee data is {item.EmployyeId},{item.Name},{item.Salary}");
        }


        for (int i = 0; i < e4.Length; i++)
        {
            Console.WriteLine($"Employee data is {e4[i].EmployyeId},{e4[i].Name},{e4[i].Salary}");
        }


    }
    private void twoDArrary()
    {
        int[,] i3 = new int[2, 3];
        i3[0, 0] = 1;
        i3[0, 1] = 2;
        i3[0, 2] = 3;
        i3[1, 0] = 4;
        i3[1, 1] = 5;
        i3[1, 2] = 6;

        Console.WriteLine($"Rows length {i3.GetLength(0)}");
        Console.WriteLine($"Columns length {i3.GetLength(1)}");

        for (int i = 0; i < i3.GetLength(0); i++)
        {
            for (int j = 0; j < i3.GetLength(1); j++)
            {
                Console.WriteLine(i3[i, j]);
            }

        }

        int[,] i4 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
        for (int i = 0; i < i4.GetLength(0); i++)
        {
            for (int j = 0; j < i4.GetLength(1); j++)
            {
                Console.WriteLine(i4[i, j]);
            }
        }
    }
    private void JaggedArrary()
    {
        int[][] i5 = new int[3][];
        i5[0] = new int[] { 1, 2, 3 };
        i5[1] = new int[] { 4 };
        i5[2] = new int[] { 5, 6 };

        for (int i = 0; i < i5.Length; i++)
        {
            for (int j = 0; j < i5[i].Length; j++)
            {
                Console.WriteLine(i5[i][j]);
            }
        }

        // int[][] i6 = new int[] { { 1, 2, 3 }, { 4 }, { 5, 6 } }; // Error

        int[][] i7 = new int[3][] {
              new int[] {1,2,3},
              new int[] {4},
              new int[] {5,6}
        };

        for (int i = 0; i < i7.Length; i++)
        {
            for (int j = 0; j < i7[i].Length; j++)
            {
                Console.WriteLine(i7[i][j]);
            }
        }
        int[][] i8 = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4 }, new int[] { 5, 6 } };
    }
    private void ArrayListLearn()
    {

        ArrayList a1 = new ArrayList();
        a1[0] = "kanumuri";
        a1.Add(1);
        a1.Add("Teja");
        a1.Add(5.2f);
        a1.Add(new Employee() { Name = "Teja", EmployyeId = 5, Salary = 4 });


        a1[1] = "Ravi";
        a1.RemoveAt(0);

        foreach (var item in a1)
        {
            Console.WriteLine(item);
        }

        for (int i = 0; i < a1.Count; i++)
        {
            Console.WriteLine(a1[i]);
        }

        ArrayList a2 = new ArrayList() { 1, "Teja", 5.2f };
        a2.Add('a');


    }
    private void ListLearn()
    {
        List<int> l1 = new List<int>();
        l1.Add(1);
        l1.Add(2);
        l1.Add(3);
        l1.Add(4);

        l1[0] = 5;

        l1.RemoveAt(0); // Index
        l1.Remove(4);   // data
        foreach (var item in l1)
        {
            Console.WriteLine(item);
        }

        for (int i = 0; i < l1.Count; i++)
        {
            Console.WriteLine(l1[i]);
        }

        List<int> l2 = new List<int>() { 1, 2, 3 };
        l2.Add(4);

        List<int> l3 = new List<int>();
        //l3[0] = 1;  // Error
        //l3[1] = 2;
        //l3[2] = 3;



        List<Employee> l4 = new List<Employee>()
        {
            new Employee(){Name = "Teja", EmployyeId = 5, Salary = 4  }
        };

        l4.Add(new Employee() { Name = "Teja6", EmployyeId = 6, Salary = 4 });
        l4.Add(new Employee() { Name = "Teja7", EmployyeId = 7, Salary = 4 });
        l4.Add(new Employee() { Name = "Teja8", EmployyeId = 8, Salary = 4 });

        Employee e1 = new Employee();
        e1.EmployyeId = 9;
        e1.Name = "teja9";
        e1.Salary = 6;
        l4.Add(e1);

    }

    private void EQCLearn()
    {

        List<string> l1 = new List<string>();
        l1.Add("test1");
        l1.Add("test2");
        l1.Add("test3");


        string[] s1 = { "test1", "test2", "test2" };
        IEnumerable<string> l2 = new List<string>() { "test1", "test2", "test3" };
        IEnumerable<string> l3 = l1;
        //l3.Add("test4"); // Error

        //Console.WriteLine(l3[0]); // Error

        foreach (var item in l3)
        {
            Console.WriteLine(item);
        }

        IQueryable<string> q1 = l1.AsQueryable();
        //q1.Add();
        foreach (var item in q1)
        {
            Console.WriteLine(item);
        }

        ICollection c1 = q1.ToList();
        //c1.Add() // Error

        foreach (var item in c1)
        {
            Console.WriteLine(item);
        }

    }

    private void HashSetLearn()
    {
        HashSet<string> s1 = new HashSet<string>();
        s1.Add("test1");
        s1.Add("test1");
        s1.Add("test1");
        s1.Add("test2");

        //Console.WriteLine(s1[0]);

        foreach (var item in s1)
        {
            Console.WriteLine(item);
        }
    }

    private void HashTableDictLearn()
    {
        Hashtable h1 = new Hashtable();
        h1.Add(1, "test1");
        h1.Add(200, 40);
        h1.Add("test2", 'a');

        Console.WriteLine(h1[1]);
        Console.WriteLine(h1["test2"]);
        foreach (var item in h1.Keys)
        {
            Console.WriteLine(h1[item]);
        }


        Dictionary<int, string> d1 = new Dictionary<int, string>();
        d1.Add(1, "test1");
        d1.Add(200, "test2");
        //d1.Add("test2", "test1"); // Error

        if (d1.ContainsKey(200))
        {
            Console.WriteLine(d1[200]);
        }

        foreach (var item in d1)
        {
            Console.WriteLine(item.Key);
            Console.WriteLine(item.Value);
        }

    }
    private void SQLearn()
    {

        // Generic
        Stack<string> s1 = new Stack<string>();
        s1.Push("test1");
        s1.Push("test2");
        s1.Push("test3");
        s1.Push("test4");

        s1.Pop();

        foreach (var item in s1)
        {
            Console.WriteLine(item);
        }

        // non generic
        Stack s2 = new Stack();


        Queue<string> s3 = new Queue<string>();
        s3.Enqueue("test1");
        s3.Enqueue("test2");
        s3.Enqueue("test3");
        s3.Enqueue("test4");


        s3.Dequeue();

        foreach (var item in s3)
        {
            Console.WriteLine(item);
        }
    }
}