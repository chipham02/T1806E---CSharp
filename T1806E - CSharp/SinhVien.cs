using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1806E___CSharp
{
    public class SinhVien
    {
        public string name;
        public int age;
        public int mark;

        public SinhVien()
        {
            this.NhapThongTin();
            this.InThongTin();
            this.BaoKetQua();
        }

        public SinhVien(int x)
        {
            Console.WriteLine("day la constructor co tham so");
        }

        public void NhapThongTin()
        {
            Console.WriteLine("Nhap ten:");
            name = Console.ReadLine();
            Console.WriteLine("Nhap tuoi:");
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem thi:");
            mark = Convert.ToInt32(Console.ReadLine());
        }

        public void InThongTin()
        {
            Console.WriteLine("Ten: " + name);
            Console.WriteLine("Tuoi: " + age);
            Console.WriteLine("Diem thi: " + mark);
        }

        public void BaoKetQua()
        {
            if (mark >= 4)
            {
                Console.WriteLine("Sinh vien da qua mon");
                return;
            }
            Console.WriteLine("Sinh vien khong qua mon");
        }

        public static void Main1(String[] args)
        {
            SinhVien sv = new SinhVien();
            sv.BaoKetQua();

        }
    }
    public static void Main(String[] args)
    {
        Human human = new Human();
        string name = Console.ReadLine();
        human.Name = "Le Van Nam";
        Console.WriteLine(human.Name);
        human[0] = 3;
        human[1] = 6;
        human[2] = 8;
        for(int i = 0; i < human.mark.Length; i++)
        {
            Console.WriteLine(human[i]);
        }
    }
}
