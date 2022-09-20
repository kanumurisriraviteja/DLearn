namespace ConsoleApp.PracProg;

class _1ProLearn
{
    public void Learn()
    {
        ReverString();
    }


    //Reverse
    // Steven Clark
    // nevetS kralC
    private void ReverString()
    {
        string ip = Console.ReadLine();
        Console.WriteLine(string.Join("", ip.Reverse()));  // This would reverse the complete string
        string[] ip1 = ip.Split(" ");
        for (int i = 0; i < ip1.Length; i++)
        {
            // Approach 1 -- By using Reverse
            Console.Write(string.Join("", ip1[i].Reverse()));
            Console.Write(" ");

            // Approach 2 -- By custom method
            //print(ip1[i]);

        }
    }

    private void print(string ip)
    {
        char[] c1 = ip.ToCharArray();
        for (int i = c1.Length - 1; i >= 0; i--)
        {
            Console.Write(c1[i]);
        }
        Console.Write(" ");
    }
}