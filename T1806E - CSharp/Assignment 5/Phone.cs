using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap.Assignment_5
{
    public interface Phone
    {
        void insertPhone(string name, string phone);
        void removePhone(String name);
        void updatePhone(String name, String newphone);
        void searchPhone(String name);
    }
}
