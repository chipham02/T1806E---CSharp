using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1806E___CSharp.Assignment_5
{
    public abstract class PhoneBook : Phone
    {
        public List<PhoneNumber> PhoneList;

        public PhoneBook()
        {
            this.PhoneList = new List<PhoneNumber>();
        }

        public void InsertPhone(String name, String phone)
        {
            for (int i = 0; i < this.PhoneList.size(); i++)
            {
                if (this.PhoneList.get(i).name.equals(name))
                {
                    if (!this.PhoneList.get(i).phone.equals(phone))
                    {
                        this.PhoneList.get(i).phone += ":" + phone;
                        return;
                    }
                    return;
                }
            }
            this.PhoneList.add(new PhoneNumber(name, phone));
        }

        public void RemovePhone(String name)
        {
            for (int i = 0; i < this.PhoneList.size(); i++)
            {
                if (this.PhoneList.get(i).name.equals(name))
                {
                    this.PhoneList.Remove(i);
                }
            }
        }

        public void UpdatePhone(String name, String newphone)
        {
            for (int i = 0; i < this.PhoneList.size(); i++)
            {
                if (this.PhoneList.get(i).name.equals(name))
                {
                    this.PhoneList.get(i) = newphone;
                }
            }
        }

        public void SearchPhone(String name)
        {
            for (int i = 0; i < this.PhoneList.size(); i++)
            {
                if (this.PhoneList.get(i).name.equals(name))
                {
                    Console.WriteLine(this.PhoneList.get(i).name + " SĐT: " + this.PhoneList.get(i).phone);
                    break;
                }
            }
        }

        public void Sort()
        {
            Collections.sort(this.PhoneList);
            for (PhoneNumber phoneNumber:this.PhoneList)
            {
                Console.WriteLine(phoneNumber.name + " SĐT: " + phoneNumber.phone);
            }
        }
    }
}
