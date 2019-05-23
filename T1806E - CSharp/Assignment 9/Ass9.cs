using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace T1806E___CSharp.Assignment_9
{
    public class Ass9
    {
        public static void Main(string[] args)
        {

            Thread t = new Thread(Boom);
            t.Start();
        }

        public static void Main1(string[] args)
        {
            Thread t = new Thread(Run);
            t.Start("Chúc mừng");
        }

            public static void Run(Object a)
        {
            while (true)
            {
                String s = (string)a;
                for (int i = 10; i > 0; i--)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                }
                Console.WriteLine(s);
            }
        }

        public static void Boom(Object o)
        {
            int m = (int)o;
            while (m > 0)
            {
                m--;
                int s = 59;
                while (s >= 0)
                {
                    Console.WriteLine(m.ToString("D2") + ":" + s.ToString("D2"));
                    s--;
                    Thread.Sleep(100);
                }
            }
            Console.WriteLine("Boom");
            
        }
    }
}
