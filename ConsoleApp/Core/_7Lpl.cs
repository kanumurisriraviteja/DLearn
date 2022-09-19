using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Core
{
    class _7Lpl
    {

        public void Learn()
        {
            floop();
            feloop();
            wloop();
            dwloop();
        }
        public void floop()
        {
            string a0 = Console.ReadLine();

            /* 
             "Test"  >> 
             T
             E
             S
             T
            */

            for (int i = 0; i < a0.Length; i++)
            {
                Console.WriteLine(a0[i]);
            }

            int a1 = Convert.ToInt32(a0);

            // l3   -- 239 >> 932  >> This code reverses the number entered
            for (int i = 1; i <= a1; a1 = a1 / 10)
                Console.Write(a1 % 10);

            Console.Write("Reverse by array");
            char[] b0 = a0.ToCharArray();

            for (int i = b0.Length - 1; i >= 0; i--)
            {
                Console.Write(b0[i]);
            }
            

            ////l2 prints all the alternate no less than the given no
            //for (int i = 1; i <= a1; i = i + 2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("====================================");

            //// l1  prints all the nos less than the given no
            //for (int i = 1; i <= a1; i++)
            //{
            //    Console.WriteLine(i);
            //}
        }

        public void feloop()
        {

            /* 
             "Test"  >> 
             T
             E
             S
             T
            */
            string a0 = Console.ReadLine();

            char[] a1 = a0.ToCharArray();

            foreach (var item in a1)
            {
                Console.WriteLine(item);
            }
        }


        public void wloop()
        {
            string a0 = Console.ReadLine();
            int a1 = Convert.ToInt32(a0);
            int i = 0;
            //l2  -- prints all the nos less than the given no
            while (i <= a1)
            {
                Console.WriteLine(i);
                i++;
            }

            // l1
            while (a1 >= 0)
            {
                Console.WriteLine(a1);
                a1--;
            }
        }
        private void dwloop()
        {
            string a0 = Console.ReadLine();
            int a1 = Convert.ToInt32(a0);
            int i = 0;

            do
            {
                if (i == 0)
                {
                    Console.WriteLine("welcome");
                    i++;
                }
                else
                {
                    Console.WriteLine(i);
                    i++;
                }

            } while (i <= a1);

        }
    }
}