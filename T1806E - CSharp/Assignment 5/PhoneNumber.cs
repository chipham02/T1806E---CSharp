using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap.Assignment_5
{
    class PhoneNumber
    {
        
        private string name;
        private string phone;

        public string Name

        {

            get { return name; }

            set { name = value; }

        }
        public string Phone

        {

            get { return phone; }

            set { phone = value; }

        }

        public PhoneNumber(string name, string phone)
        {
            Name = name;

            Phone = phone;
        }
    }
}
