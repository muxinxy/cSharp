using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_exchange
{
    class Exchange
    {
        public static void Swap1(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine("交换后a={0},b={1}", x, y);
        }
        public void Swap2(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine("交换后a={0},b={1}", x, y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("请输入一个整数（a）:");
            a=Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入一个整数（b）:");
            b = Convert.ToInt32(Console.ReadLine());
            Exchange.Swap1(ref a, ref b);
            Console.Write("请输入一个整数（a）:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入一个整数（b）:");
            b = Convert.ToInt32(Console.ReadLine());
            Exchange exchange = new Exchange();
            exchange.Swap2(ref a, ref b);
        }
    }
}
