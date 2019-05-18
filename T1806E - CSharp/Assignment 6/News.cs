using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1806E___CSharp.Assignment_6
{
    class News : INews
    {
        public static void Main(string[] args)
        {

        }

        public int ID;
        public String Title;
        public String PublishDate;
        public String Author;
        public String Content;
        public float AverageRate;
        public int[] RateList = new int[3];

        public News()
        {
            Console.WriteLine("Nhập ID: ");
            ID = Int32.Parse(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("Nhập Title: ");
            Title = Console.ReadLine();
            Console.WriteLine("Nhập PublishDate: ");
            PublishDate = Console.ReadLine();
            Console.WriteLine("Nhập Content: ");
            Content = Console.ReadLine();

            Console.WriteLine("3 rate: ");
            for (int i = 0; i < 3; i++)
            {
                RateList[i] = Int16.Parse(Console.ReadLine());
            }
        }

        public void Display()
        {
            Console.WriteLine("ID: " + ID + "Title: " + Title + "PublishDate: " + PublishDate + "Author: " + Author + "Content: " + Content + "AverageRate: " + AverageRate);
        }

        public void Calculate()
        {
            int total = 0;
            foreach (int i in RateList)
            {
                total += i;
            }
            AverageRate = (float)total / 3;
        }
    }
}
