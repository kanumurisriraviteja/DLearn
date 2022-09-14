using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Core
{
    class DecL
    {
        public void DecisionMaking()
        {

            Console.WriteLine("Enter first ip");
            string a0 = Console.ReadLine();
            int a1 = Convert.ToInt32(a0);

            Console.WriteLine("Enter second ip");
            string a2 = Console.ReadLine();
            int a3 = Convert.ToInt32(a2);

            Console.WriteLine("Chooose the operation: +,-,*,/");
            string a4 = Console.ReadLine();

            int a5 = 0;
            // Approach - 1 using if 
            //a5 = Learnife(a1, a3, a4, a5);

            // Approach - 3 switch
            a5 = Learnsw(a1, a3, a4, a5);


            //Approach - 4 using conditional operator
            //a5 = a4 == "+" ? Add(a1, a3) : 0;
            a5 = a4 == "+" ? Add(a1, a3) : (a4 == "-" ? Sub(a1, a3) : (a4 == "*" ? Mult(a1, a3) : (a4 == "/" ? Div(a1, a3) : 0)));

        }

        private int Learnsw(int a1, int a3, string a4, int a5)
        {

            // apr -3.1
            switch (a4)
            {
                case "+":
                    a5 = Add(a1, a3);
                    break;
                case "-":
                    a5 = Sub(a1, a3);
                    break;
                case "*":
                    a5 = Mult(a1, a3);
                    break;
                case "/":
                    a5 = Div(a1, a3);
                    break;
                default:
                    Console.WriteLine("==Invalid Operator==");
                    break;
            }
            // apr -3.2

            switch (a4)
            {
                case "+":
                case "-":
                    a5 = Sub(a1, a3);
                    break;
                case "*":
                    a5 = Mult(a1, a3);
                    break;
                case "/":
                    a5 = Div(a1, a3);
                    break;
                default:
                    Console.WriteLine("==Invalid Operator==");
                    break;
            }
            //if (a4 == "+" || a4 == "-") { a5 = Sub(a1, a3); }

            return a5;
        }

        private int Learnife(int a1, int a3, string a4, int a5)
        {

            if (a4 == "+")
            {
                a5 = Add(a1, a3);
                if (a5 % 2 == 0)
                {
                    Console.WriteLine("The op is divisible by 2");
                }

                Console.WriteLine(a5);
            }
            else if (a4 == "-")
            {
                a5 = Sub(a1, a3);
                Console.WriteLine(a5);
            }
            else if (a4 == "*")
            {
                a5 = Mult(a1, a3);
                Console.WriteLine(a5);
            }
            else if (a4 == "/")
            {
                a5 = Div(a1, a3);
                Console.WriteLine(a5);
            }
            else
            {
                if (a5 == 0) { }
                Console.WriteLine("==Invalid Operator==");
            }


            // Approach - 2 -- not best for our scenio's

            //if (a4 == "+")
            //{
            //    a5 = Add(a1, a3);
            //    Console.WriteLine(a5);
            //}
            //if (a4 == "-")
            //{
            //    a5 = Sub(a1, a3);
            //    Console.WriteLine(a5);
            //}
            return a5;
        }

        private int Add(int a, int b)
        {
            return a + b;
        }

        private int Sub(int a, int b)
        {
            return a - b;
        }

        private int Mult(int a, int b)
        {
            return a * b;
        }

        private int Div(int a, int b)
        {
            return a / b;
        }
    }
}
