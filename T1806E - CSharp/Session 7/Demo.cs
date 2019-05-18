using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1806E___CSharp.Session_7
{
    class Demo
    {
        public delegate void Numeric(int a, int b);

        public static void Main(string[] args)
        {
            Numeric n1 = new Numeric(Sum);
            Numeric n2 = new Numeric(Minus);
            Numeric n3 = new Numeric(Multiple);
            Numeric n4 = new Numeric(Devide);
            //n1(3, 2);
            //n1 += n3;
            //n1(5, 6);
            //n3 += n4;
            //n2 += n3;
            //n1 += n2;

            n1 += n2;
            n2 += n3;
            n3 += n4;

            n1(10, 5);
        }

        public static void Sum(int a, int b)
        {
            Console.WriteLine("Sum: " +(a+b));
        }

        public static void Minus(int a, int b)
        {
            Console.WriteLine("Sum: " + (a - b));
        }

        public static void Multiple(int a, int b)
        {
            Console.WriteLine("Sum: " + (a * b));
        }

        public static void Devide(int a,int b)
        {
            Console.WriteLine("Sum: " + (a / b));
        }
    }
}
