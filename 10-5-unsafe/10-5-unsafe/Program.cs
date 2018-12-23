using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_5_unsafe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            unsafe
            {
                fixed (int* p = &a[0])
                {
                    int* pt = p;
                    for (int i = 0; i < 10; i++)
                    {
                        *pt = i;
                        Console.WriteLine(*pt);
                        pt++;
                    }
                }
            }
        }
    }
}
