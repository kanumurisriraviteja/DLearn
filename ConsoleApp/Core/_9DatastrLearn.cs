namespace ConsoleApp.Core;

class _9DatastrLearn
{
    //Array,ArrarList,List,IEnumerable,IQueryable,ICollection,HashTable,Dictionary,Queue,Stack.
    // struct,enum,class
    public void Learn()
    {
        //ArrayLearn();
    }

    private void ArrayLearn()
    {
        oneDArray();
        twoDArrary();
        JaggedArrary();
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

}