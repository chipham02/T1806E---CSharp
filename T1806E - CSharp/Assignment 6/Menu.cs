using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1806E___CSharp.Assignment_6
{
    public class Menu
    {
        public static void Main(string[] args)
        {
            int[] RateList = { 1, 2, 3 };
            News program = new News(121, "Cô gái đến từ hôm qua", "05/03/2019", "Nguyễn Nhật Ánh", "Đọc là biết", RateList);
            program.Calculate();
            program.Display();
        }
    }
}
