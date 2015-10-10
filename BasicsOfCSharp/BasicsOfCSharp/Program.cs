using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Property String");
            Console.WriteLine("Length, ,ToUpper(), ToLower(), Replace(), Concat(), Equals()");
            Console.WriteLine("Trim(), Remove(), Insert(), PadLeft(), PadRight(), Format()");
            Console.WriteLine("Compare(), Concatins()");
            Console.WriteLine();

            string str1 = "friday";
            string str2 = "FRIDAY";
            string str3 = "Hello";
            string str4 = "World";
            Console.WriteLine("{0}.Length = {1}", str1, str1.Length);
            Console.WriteLine("{0}.ToUpper() = {1}", str1, str1.ToUpper());
            Console.WriteLine("{0}.ToLower() = {1}", str2, str2.ToLower()); 
            Console.WriteLine("{0}.Replace() = {1}", str1, str1.Replace("f", "F"));
            Console.WriteLine();

            Console.WriteLine("{0} + {1} = {2} - s1 + s2", str3, str4, str3+str4);
            string s1 = str3 + str4;
            string s2 = String.Concat(str3, str4);
            Console.WriteLine("{0} + {1} = {2} - String.Concat(s1, s2)", str3, str4, String.Concat(str3, str4));
            Console.WriteLine();

            Console.WriteLine("s1.Equals(s2) = {0}", s1.Equals(s2));
            Console.WriteLine("friday.Equals(FRIDAY) = {0}", str1.Equals(str2));
            Console.WriteLine("s1 == s2 -> {0}", s1 == s2);
            Console.WriteLine("String.Compare({0}, {1}) = {2}", str1, str2, String.Compare(str1, str2));
           

            Console.WriteLine();

            string s3 = "     word";
            Console.WriteLine("'{0}'.Trim() = '{1}'", s3, s3.Trim());

            Console.WriteLine("{0}.Remove(1) = {1}", str1, str1.Remove(1));
            Console.WriteLine("{0}.Remove(2) = {1}", str1, str1.Remove(2));
            Console.WriteLine("{0}.Remove(3) = {1}", str1, str1.Remove(3));
            Console.WriteLine("{0}.Remove(5) = {1}", str1, str1.Remove(5));
            Console.WriteLine();
            Console.WriteLine("{0}.Insert(2, {1} = {2})",str1, str2, str1.Insert(2, str2));
            Console.WriteLine("{0}.PadLeft({0}.Length+4, 'a') = {1}", str1, str1.PadLeft(str1.Length + 4, 'a'));
            Console.WriteLine("{0}.PadRight({0}.Length+4, 'a') = {1}", str1, str1.PadRight(str1.Length + 4, 'a'));
            Console.WriteLine();
            decimal temp = 20.4m;
            string s = String.Format("The temperature is {0}°C.", temp);
            Console.WriteLine("String.Format()");
            Console.WriteLine(s);
            string s5 = "Hello World";
            Console.WriteLine("{0}.Contains({1}) = {2}", s5, str4, s5.Contains(str4));
            Console.WriteLine("{0}.Contains({1}) = {2}", s5, str1, s5.Contains(str1));
            
            Console.ReadKey();
        }
    }
}
