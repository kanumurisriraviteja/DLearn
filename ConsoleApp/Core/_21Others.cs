using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Core
{
    public class _21Others
    {
        public void Learn()
        {
            // Tuples
            var se = SumEven(12445);
            Console.WriteLine($"The sum of no is {se.Item1} and the no is {(se.Item2 ? "is" : "not")} even");

            // Extension Methods.
            EMLearn();

            // ref, out variables
            RefOutLearn();
        }
        private static (int, bool) SumEven(int number)
        {
            int givenNo = number;
            int sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            bool isEven = givenNo % 2 == 0 ? true : false;
            return (sum, isEven);
        }
        private static void EMLearn()
        {
            // Extensions Methods - Created in the static class _3Sl
            // This acts like a method extension
            string a = "teja";
            Console.WriteLine(a.CountVowels(a));
            int i1 = 224400;
            Console.WriteLine(i1.Countzeros());
        }
        private void RefOutLearn()
        {
            int i1 = 1_00_000;
            int i2 = 2_000;
            int i3_0 = 0;
            int i3_1 = 0;
            int i4_0 = 0;
            int i4_1;
            int i5 = 0;
            int i6;
            RefLearn(i1, i2, ref i3_0, ref i3_1);
            System.Console.WriteLine($"The Sum is {i3_0} and the product is {i3_1}");
            // RefLearn(i1,i2,ref i5,ref i6); // Error ref must be initialized, Here i6 is not initialized
            OutLearn(i1, i2, out i4_0, out i4_1); // Out may or may not be initialized
            System.Console.WriteLine($"The Sum is {i4_0} and the product is {i4_1}");

            // Here as the value is not passed the we can write the code as below 
            OutLearn(i1, i2, out int i7, out int i8); // Out may or may not be initialized
            System.Console.WriteLine($"The Sum is {i7} and the product is {i8}");
        }
        private void RefLearn(int i11, int i12, ref int i13_0, ref int i13_1)
        {
            // If these values are commented ref will not throw an error 
            i13_0 = i11 + i12;
            i13_1 = i11 * i12;
        }
        private void OutLearn(int i11, int i12, out int i14_0, out int i14_1)
        {
            // If these values are commented out will throw an error, we should definately return value in the out
            //The out parameter 'i14_1' must be assigned to before control leaves the current method if commented
            i14_0 = i11 + i12;
            i14_1 = i11 * i12;
        }
    }
}
