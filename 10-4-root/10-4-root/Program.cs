using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_4_root
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, x1, x2;
            Console.WriteLine("请输入a b c");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            try
            {
                d = b * b - 4 * a * c;
                if (d < 0)
                {
                    throw (new MyException("方程没有实根！"));
                }
                else
                {
                    x1 = (-b + Math.Sqrt(d)) / 2 * a;
                    Console.WriteLine("x1={0}", x1);
                    x2 = (-b - Math.Sqrt(d)) / 2 * a;
                    Console.WriteLine("x2={0}", x2);
                }
            }catch(MyException me)
            {
                Console.WriteLine(me.Message);
            }
        }
    }
    class MyException : ApplicationException
    {
        public MyException(string message) : base(message) { }
        public MyException(string message, Exception innerException) : base(message, innerException) { }
    }
}