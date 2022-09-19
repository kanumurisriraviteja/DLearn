namespace ConsoleApp.Core;

class _9DatastrLearn
{

    public void Learn()
    {
        // 1-D int arrary 
        // int[]  i0 = new int[]; // Error
        int[] i0 = new int[10]; // Error
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
}