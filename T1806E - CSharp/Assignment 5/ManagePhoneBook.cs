using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap.Assignment_5
{
    class ManagePhoneBook
    {
        static void Main5(string[] args)
        {
            List<PhoneNumber> listDbs = new List<PhoneNumber>();
            PhoneBook list = new PhoneBook(listDbs);
            Boolean flag = true;

            while (flag)
            {
                Console.WriteLine("1:Insert phone");
                Console.WriteLine("2:Remove phone");
                Console.WriteLine("3:Update  phone");
                Console.WriteLine("4:Search phone");
                int chon = Int32.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        {
                            Console.WriteLine("Nhập tên");
                            String name = Console.ReadLine();
                            Console.WriteLine("Nhập sdt");
                            String sdt = Console.ReadLine();
                            list.insertPhone(name, sdt);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Nhập tên");
                            String name = Console.ReadLine();
                            list.removePhone(name);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Nhập tên");
                            String name = Console.ReadLine();
                            Console.WriteLine("Nhập sdt mới");
                            String sdt = Console.ReadLine();
                            list.updatePhone(name, sdt);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Nhập tên");
                            String name = Console.ReadLine();
                            list.searchPhone(name);
                            break;
                        }
                }
            }
        }
    }
}
