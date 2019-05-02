using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1806E___CSharp.Assignment_4
{
    public class Menu
    {
        public static void Main(String[] args)
        {
            List<News> ListNews = new List<News>();
            bool start = true;
            while(start)
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("1. Insert news");
                Console.WriteLine("2. View list news");
                Console.WriteLine("3. Average rate");
                Console.WriteLine("4. Exit");

                int menu = Int16.Parse(Console.ReadLine());
                if(menu > 0 || menu < 5)
                {
                    switch (menu)
                    {
                        case 1:
                            ListNews.Add(new News());
                            break;
                        case 2:
                            ViewAll(ListNews); 
                            break;
                        case 3:
                            AvgAndViewAll(ListNews);
                            break;
                        case 4:
                            start = false;
                            break;
                    }
                    
                }
                    
            } 
        }

        public static void ViewAll(List<News> listNews)
        {
            foreach(News x in listNews)
            {
                x.Display();
            }
        }

        public static void AvgAndViewAll(List<News> listNews)
        {
            foreach(News x in listNews)
            {
                x.Calculate();
                x.Display();
            }
        }
    }
}
