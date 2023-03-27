using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Core
{
    internal class _18Del
    {

        public void Learn()
        {
            m1("test");
            TestDel test = new TestDel(m1);
            Action<string> action = m1;
            test("test");
            TestDel1 testDel1 = new TestDel1(m2);
            TestDel1 testDel3 = m2;
            testDel1("test");

            Func<string, int> func1 = m4;
            int a = func1("testy");
            Func<int, string> f1 = x => x > 0 ? "positive" : x < 0 ? "negative" : "zero";
            System.Console.WriteLine(f1(1));

            TestDel2 testDel2 = new TestDel2(m3);
            testDel2("test");

            Predicate<string> a1 = m3;
            bool a2 = a1("tte");

        }

        public delegate void TestDel(string s);
        public void m1(string s)
        {
            Console.WriteLine("This is m1 method");
        }


        public delegate int TestDel1(string s);
        public int m2(string s)
        {
            return 5;
        }

        public int m4(string s)
        {
            return 5;
        }


        public delegate bool TestDel2(string s);
        public bool m3(string s)
        {

            m5(Learn);

            return true;
        }


        public void m5(Action action)
        {

        }
    }
}
