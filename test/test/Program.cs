using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=4;
            int z;
            z = ~(((1 << 31) >> 31) << n);
            Console.WriteLine((0x87654321 >> 28 & z)+(0x87654321<<n));
        }
    }
}
