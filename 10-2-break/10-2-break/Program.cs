using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2_break
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5000];
            for(int i=0;i<=5000;i++)
            {
                a[i] = i;
                Console.WriteLine(a[i]);
            }
        }
    }
}
