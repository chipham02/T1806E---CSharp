using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1806E___CSharp.Exam
{
    class MobilePhone : Product
    {
        public MobilePhone(int product_id, string product_name, string producer, double price) : base(product_id, product_name, producer, price)
        {

        }

        public override double computeTax()
        {
            return this.Price / 100 * 10;
        }
    }
}
