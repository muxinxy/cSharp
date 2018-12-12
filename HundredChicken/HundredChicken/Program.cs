using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundredChicken
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[10];
            int[] y = new int[10];
            int[] z = new int[10];
            int a = 0, b = 0, c = 0;
            for(int i=0;i<100;i++)
            {
                for(int j=0;j<100;j++)
                {
                    if((7*i+4*j)==100)
                    {
                        x[a++] = i;
                        y[b++] = j;
                        z[c++] = 100 - i - j;
                    }
                }
            }
            Console.WriteLine("公鸡  母鸡  小鸡");
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(" {0}     {1}    {2}", x[i], y[i], z[i]);
            }
        }
    }
}
