using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _10_1_trace
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, num1, num2;
            Console.WriteLine("请输入整数（a b）:");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            a = num1;
            b = num2;
            while (b != 0)
            {
                c = a % b;
                Trace.WriteLine("c=" + c.ToString());
3                a = b;
                Debug.WriteLine("a=" + a.ToString());
                b = c;
            }
            Console.WriteLine("最大公约数：{0}\n", a);
            a = num1 * num2 / a;
            Console.WriteLine("最小公倍数：{0}", a);
        }
    }
}
