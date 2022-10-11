namespace ConsoleApp.Core;


public class _17Ind
{

    private string[] val = new string[3];
     
    public string this[int index]
    {
        get
        {
            return val[index];
        }
        set
        {
            val[index] = value;
        }
    }

    public string[] valuearr = new string[3];

}