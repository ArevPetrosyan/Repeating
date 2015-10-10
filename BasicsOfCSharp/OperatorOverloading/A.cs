using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
        class A
        {
            public int X { get; set; }

            public static A operator +(A a, B b)
            {
                return new A();
            }
            public static A operator +(B b, A a)
            {
                return new A();
            }
        }
}
