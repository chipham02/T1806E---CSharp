using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1806E___CSharp.Session_2;
namespace T1806E___CSharp
{
    public class Asian : Human, IHuman
    {
        public Asian()
        {
            this.id = 10;
        }

        public void Jump()
        {
            throw new NotImplementedException();
        }

        public override void Run()
        {

        }

        public new void Run(int number)
        {

        }
    }
}
