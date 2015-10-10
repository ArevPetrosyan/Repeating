using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Bank
    {
        public static int balance=10;
        public int sum;
        public void AddSum()
        {
            sum += balance;
        }
        public static int AddBalance(int b)
        {
            //return sum += b;//sum is not static
            return balance += b;
        }
    }
}
