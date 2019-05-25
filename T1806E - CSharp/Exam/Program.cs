using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1806E___CSharp.Exam
{
    class Program
    {
        public static List<Product> list = new List<Product>();

        static void Main(string[] args)
        {
            Book book1 = new Book(1, "sach giao khoa", "kim dong", 20000);
            Book book2 = new Book(2, "sach tieu hoc", "quoc gia", 30000);
            Book book3 = new Book(3, "sach trung hoc", "quoc gia", 40000);
            MobilePhone phone1 = new MobilePhone(1, "iphone", "apple", 200000);
            MobilePhone phone2 = new MobilePhone(2, "samsung", "han quoc", 300000);
            MobilePhone phone3 = new MobilePhone(3, "galaxy", "han quoc", 400000);
            list.Add(book1);
            list.Add(book2);
            list.Add(book3);
            list.Add(phone1);
            list.Add(phone2);
            list.Add(phone3);
            double sum = 0;
            foreach (Product pro in list)
            {
                sum += pro.computeTax();
            }
            Console.WriteLine(sum);
        }
    }
}
