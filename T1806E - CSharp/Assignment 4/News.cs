using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1806E___CSharp.Assignment_4
{
    public class News : INews
    {
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
            for(int i=0; i<3; i++)
            {
                RateList[i] = Int16.Parse(Console.ReadLine());
            }

        }
        
        public int id
        {
            get
            {
                return ID;
            }
            set
            {
                this.id = value;
            }
        }

        public String title
        {
            get
            {
                return Title;
            }
            set
            {
                this.Title = value;
            }
        }

        public String publishDate
        {
            get
            {
                return PublishDate;
            }
            set
            {
                this.PublishDate = value;
            }
        }

        public String author
        {
            get
            {
                return Author;
            }
            set
            {
                this.Author = value;
            }
        }

        public String content
        {
            get
            {
                return Content;
            }
            set
            {
                this.Content = value;
            }
        }


        public void Display()
        {
            Console.WriteLine("ID: " + ID + "Title: " + Title + "PublishDate: " + PublishDate + "Author: " + Author + "Content: " + Content +"AverageRate: " + AverageRate);
        }

        public void Calculate()
        {
            int total = 0;
            foreach(int i in RateList)
            {
                total += i;
            }
            AverageRate = (float)total / 3;
        }
    }
}
