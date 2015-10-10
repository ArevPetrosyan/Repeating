using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class B
    {
        public int Y { get; set; }

        public static B operator +(B b, A a)
        {
            return new B();
        }
        public static B operator +(A a, B b)
        {
            return new B();
        }
    }
}
