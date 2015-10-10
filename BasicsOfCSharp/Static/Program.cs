using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    //class data
    //class methods
    //class properties
    //constructors
    //whole class

    class Program
    {
        static void Main(string[] args)
        {
            Bank myBank = new Bank();
            Console.WriteLine("balance {0}",Bank.balance);
            myBank.sum = 150;
            myBank.AddSum();
            Console.WriteLine("my sum {0}", myBank.sum);
            Console.WriteLine("Add Balance  {0}", Bank.AddBalance(5));
            Console.WriteLine();
            Bank yorBank = new Bank();
            Console.WriteLine(Bank.balance);
            
            Console.ReadKey();
        }
    }
}
