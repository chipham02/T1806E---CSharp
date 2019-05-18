using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1806E___CSharp.Session_7
{
    class Program
    {
        public delegate void showString(String s);

        public static void Main(string[] args)
        {
            showString ss = new showString(showStringProgram);
            showString s2 = new showString(showStringPro);
            ss += s2;
            //cách 1
            ss("hello");
            //cách 2
            //ss.Invoke("hello");

        }

        public static void showStringProgram(string x)
        {
            Console.WriteLine(x);
        }

        public static void showStringPro(String x)
        {
            Console.WriteLine("show String: " + x);
        }
    }
}
