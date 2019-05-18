using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1806E___CSharp.Session_6
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int x = 1;
                x++;
                int y = x / 0;
            }catch(DivideByZeroException e)
            {
                Console.WriteLine("không thể chia cho 0");
            }catch(InvalidOperationException e)
            {

            }catch(Exception e)
            {
                Console.WriteLine("Error" + e.Message);
            }
            finally
            {
                Console.WriteLine("finish...");
            }

        }
    }
}
