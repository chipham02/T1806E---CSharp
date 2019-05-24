using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap.Assignment_5
{
    class PhoneBook : Phone
    {
        List<PhoneNumber> PhoneList = new List<PhoneNumber>();

        public PhoneBook(List<PhoneNumber> phoneList)
        {
            PhoneList = phoneList;
        }

        public void insertPhone(string name, string phone)
        {

            foreach (PhoneNumber item in PhoneList)
            {
                if (!item.Name.Equals(name))
                {
                    Console.WriteLine("Test");
                    PhoneList.Add(new PhoneNumber(name, phone));
                }
                if (!item.Name.Equals(phone))
                {
                    item.Phone += phone;
                }

            }
        }

        public void removePhone(string name)
        {
            foreach (PhoneNumber item in PhoneList)
            {
                if (item.Equals(name))
                {
                    PhoneList.Remove(item);
                }
            }
        }

        public void searchPhone(string name)
        {
            foreach (ListDB item in PhoneList)
            {
                if (item.Name.Equals(name))
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void updatePhone(string name, string newphone)
        {
            foreach (ListDB item in PhoneList)
            {
                if (item.Name.Equals(name))
                {
                    item.Phone = newphone;

                }
            }
        }
    }
}
