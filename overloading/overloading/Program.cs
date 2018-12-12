using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading
{
    class Program
    {
        public static int add(int a,int b)
        {
            return (a + b);
        }

        public static double add(double a,double b)
        {
            return (a + b);
        }

        public static int mul(int a,int b)
        {
            return (a * b);
        }

        public static double mul(double a,double b)
        {
            return (a * b);
        }

        public delegate int Calculate(int x,int y);

        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("请输入整数a：");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入整数b：");
            b = Convert.ToInt32(Console.ReadLine());
            Calculate cal1 = new Calculate(add);
            Calculate cal2 = new Calculate(mul);
            if (a < 10 && b < 10)
            {
                Console.WriteLine("相加的结果：");
                Console.WriteLine(cal1(a, b));
            }
            else {
                Console.WriteLine("相乘的结果：");
                Console.WriteLine(cal2(a, b));
            }
        }
    }
}
