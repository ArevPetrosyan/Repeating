using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            //(input parameters) => expression

            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int c = nums.Where(i => i > 6).Count();
            Console.WriteLine(c);

            int[] nums2 = new int[] { 6, 2, 7, 1, 9, 3 };
            IEnumerable<int> numsLessThanFour = nums2
              .Where(i => i < 4)
              .OrderBy(i => i);
            foreach (int item in numsLessThanFour)
            {
                Console.Write(item+" ");
            }

            Console.Read();
        }
    }
}
