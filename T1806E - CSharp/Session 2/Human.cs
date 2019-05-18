using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1806E___CSharp
{
    public class Human
    {
        public int id;
        public string name;
        public int age;
        public int[] mark = new int[3]; 

        public int this[int index]
        {
            get
            {
                return mark[index];
            }
            set
            {
                mark[index] = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                this.id = value;
            }
        }

        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                this.age = value;
            }
        }

        public Human()
        {

        }

        public virtual void Run()
        {

        }

        public void Run(int number)
        {

        }

        public void Run(String str)
        {

        }
    }
}
