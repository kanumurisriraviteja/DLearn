namespace ConsoleApp.Core;
using System.Text;


class _8StrLearn
{
    public void Learn()
    {
        StringOpeations1();
        StringOpeations2();
        StringOpeations3();

    }

    private void StringOpeations1()
    {
        string s1 = "test";
        string s2 = s1 + "1";
        Console.WriteLine(s1.GetHashCode());
        Console.WriteLine(s2.GetHashCode());
        string s3 = "1";
        string s4 = "2";
        string s5 = s3 + s4;
        string s6 = s5;
        Console.WriteLine(s2);  // test1
        Console.WriteLine(s5); // 12
        Console.WriteLine(s5.GetHashCode());
        Console.WriteLine(s6.GetHashCode());
        s6 = s6 + "3";
        Console.WriteLine(s6.GetHashCode());


        Console.WriteLine("=============================");
        StringBuilder sb = new StringBuilder();
        Console.WriteLine(s6.GetHashCode());
        sb.Append("1");
        Console.WriteLine(s6.GetHashCode());
        sb.Append("2");
        Console.WriteLine(s6.GetHashCode());

        StringBuilder sb2 = new StringBuilder("ABC");
        sb2.Append("DEFG");
        Console.WriteLine(sb2.ToString());
        string s7 = sb2.ToString();
    }

    private void StringOpeations2()
    {


        String a = "hello";
        String b = (String)a.Clone();
        Console.WriteLine(b);

        string c = a + b;
        Console.WriteLine(string.Concat(a, b));
        Console.WriteLine(c);

        Console.WriteLine("occurence of e {0}", c.IndexOf('e'));
        Console.WriteLine(c.Substring(2));
        Console.WriteLine(c.Substring(2, 4));

        string d = " " + a + " ";
        Console.WriteLine(d.Length);
        d = d.TrimStart();
        Console.WriteLine(d);
        Console.WriteLine(d.Length);
        d = d.TrimEnd();
        Console.WriteLine(d);
        Console.WriteLine(d.Length);

        d = d.Trim();
        Console.WriteLine(d);
        Console.WriteLine(d.Length);

        Console.WriteLine(d.ToUpper());


        string[] s2 = c.Split('e');
        foreach (var a0 in s2)
        {
            Console.WriteLine(a0);
        }
        char[] s3 = c.ToCharArray();

    }

    private void StringOpeations3()
    {

        //1 same instance for the string.
        string s1 = "teja";
        string s2 = "teja";
        Console.WriteLine(Object.ReferenceEquals(s1, s2));//True
        Console.WriteLine(Object.Equals(s1, s2));//True
        Console.WriteLine(s1.GetHashCode());//1230421684
        Console.WriteLine(s2.GetHashCode());//1230421684 // s2 will point to the same instance.


        //2 string is immutable
        string test = "ddd";
        Console.WriteLine(test.GetHashCode());//-1029223246
        test = test.Remove(0, 1);
        Console.WriteLine(test.GetHashCode());//-840517700 New instance is created.

        //string builder is mutable
        StringBuilder a = new StringBuilder();
        a.Append("t");
        Console.WriteLine(a.GetHashCode());//46104728
        a.Append("tas");
        Console.WriteLine(a.Remove(0, 1).GetHashCode());//46104728 we will have the same instance.


        string firstname;
        string lastname;
        string testname;

        firstname = "Steven Clark";
        lastname = "Clark";
        Console.WriteLine("=============");
        Console.WriteLine(firstname.GetHashCode());//1470518261
                                                   // Makes String Clone
        testname = firstname.Clone().ToString();
        Console.WriteLine(testname.GetHashCode());//1470518261 has the same instance.
        testname = firstname;
        Console.WriteLine(testname.GetHashCode());//1470518261 has the same instance.
        testname = String.Copy(testname);
        Console.WriteLine(testname.GetHashCode());//1470518261 has the same instance.


        //Compare two string value and returns 0 for true and     1 for false
        Console.WriteLine(firstname.CompareTo(lastname));//1
        Console.WriteLine(firstname.CompareTo(testname));//0

        //Compare two string and returns true and false
        Console.WriteLine(firstname.Equals(lastname));// False
        Console.WriteLine(firstname.Equals(testname));//True

        Console.WriteLine(firstname == lastname); //false



        //Check whether specified value exists or not in string
        Console.WriteLine(firstname.Contains("ven"));//True


        //Returns HashCode of String
        Console.WriteLine(firstname.GetHashCode());

        //Returns type of string
        Console.WriteLine(firstname.GetType());//System.String

        //Returns type of string
        Console.WriteLine(firstname.GetTypeCode());//String


        //Returns the first index position of specified value  the first index position of specified value
        Console.WriteLine(firstname.IndexOf("e")); //2


        //Returns the last index position of specified value
        Console.WriteLine(firstname.LastIndexOf("e")); //4

        //Covert string into lower case
        Console.WriteLine(firstname.ToLower());//steven clark

        //Convert string into Upper case
        Console.WriteLine(firstname.ToUpper());//STEVEN CLARK

        //Insert substring into string
        Console.WriteLine(firstname.Insert(0, "Hello")); //HelloSteven Clark


        Console.WriteLine(firstname.IsNormalized());//True.
                                                    //Check Whether string is in Unicode normalization from C

        //Returns the Length of String
        Console.WriteLine(firstname.Length);//12


        //Deletes all the characters from begining to specified index.
        Console.WriteLine(firstname.Remove(5));//Steve

        // Replace the character
        Console.WriteLine(firstname.Replace('e', 'i'));//Stivin Clark

        //Split the string based on specified value
        string[] split = firstname.Split(new char[] { 'e' });

        Console.WriteLine(split[0]);//St
        Console.WriteLine(split[1]);//v
        Console.WriteLine(split[2]);//n Clark

        //Check wheter first character of string is same as specified value
        Console.WriteLine(firstname.StartsWith("S")); //True

        //Check whether specified value is the last character of string
        Console.WriteLine(firstname.EndsWith("n")); // False


        //Returns substring start position and give the length of the characters.
        Console.WriteLine(firstname.Substring(2, 5));//even


        //Converts an string into char array.
        Char[] charArray = firstname.ToCharArray();
        Console.WriteLine(charArray);//Steven Clark

        //It removes starting and ending white spaces from  string.
        Console.WriteLine(firstname.Trim());//Steven Clark

        //kralC nevetS
        //Reverse the string
        //Reverse() will only return the IEnumerable Array.
        Console.WriteLine(string.Join("", firstname.Reverse()));
        

        string[] starray = new string[]{"Down the way nights are dark",
            "And the sun shines daily on the mountain top",
            "I took a trip on a sailing ship",
            "And when I reached Jamaica",
            "I made a stop"};

        string str = String.Join("\n", starray);

        char[] c1 = { 'a', 'b', 'c' };
        Console.WriteLine(string.Join("", c1)); // abc

    }

}