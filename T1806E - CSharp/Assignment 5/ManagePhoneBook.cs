using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1806E___CSharp.Assignment_5
{
    public class ManagePhoneBook
    {
        public static void main(String[] args)
        {
            PhoneBook phoneBook = new PhoneBook();
            String name;
            String phone;
            bool start = true;
            while (start)
            {
                Console.WriteLine("PHONE MANAGEMENT SYSTEM: ");
                Console.WriteLine("1. Insert Phone");
                Console.WriteLine("2. Remove Phone");
                Console.WriteLine("3. Update Phone");
                Console.WriteLine("4. Search Phone");
                Console.WriteLine("5. Sort");

                int menu = Int16.Parse(Console.ReadLine());
                if (menu > 0 || menu < 5)
                {
                    switch (menu)
                    {
                        case 1:
                            ManagePhoneBook.InputName();
                            ManagePhoneBook.InputPhone();
                            phoneBook.insertPhone(name, phone);
                            break;
                        case 2:
                            name = ManagePhoneBook.InputName();
                            phoneBook.removePhone(name);
                            break;
                        case 3:
                            name = ManagePhoneBook.InputName();
                            phone = ManagePhoneBook.InputPhone();
                            phoneBook.updatePhone(name, phone);
                            break;
                        case 4:
                            name = ManagePhoneBook.InputName();
                            phoneBook.SearchPhone(name);
                            break;
                        case 5:
                            phoneBook.Sort();
                            break;
                        case 6: start = false; break;
                    }
                }
            }
        }       
  
    public static void InputName()
        {
            Console.WriteLine("Input Name: ");
            String string = Console.ReadLine();
            return string;
        }

        public static void InputPhone()
        {
            Console.WriteLine("Input Phone: ");
            String string = Console.ReadLine();
            return string;
        }
    }
}
