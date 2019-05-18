using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1806E___CSharp.Assignment_5
{
    public abstract class PhoneNumber : Comparer<PhoneNumber>
    {

        public String name;
        public String phone;

        public PhoneNumber(String name, String phone)
        {
            this.name = name;
            this.phone = phone;
        }

        public int compareTo(PhoneNumber phoneNumber)
        {
            return this.name.CompareTo(phoneNumber.name);
        }

    }
}
