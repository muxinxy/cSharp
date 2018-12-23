using System;
using System.Threading;

namespace _12_1_tickets
{
    internal class Program
    {
        public static int sum = 100;
        public static int w1 = 0;
        public static int w2 = 0;
        public static int w3 = 0;
        private static object objlock = new object();

        public void Window1()
        {
            while (sum > 0)
            {
                Thread.Sleep(10);
                lock (objlock)
                {
                    if (sum > 0)
                    {
                        sum--;
                        w1++;
                        Console.WriteLine("窗口 1 售出一张票，剩余票数{0}", sum);
                    }
                }
            }
        }

        public void Window2()
        {
            while (sum > 0)
            {
                Thread.Sleep(10);
                lock (objlock)
                {
                    if (sum > 0)
                    {
                        sum--;
                        w2++;
                        Console.WriteLine("窗口 2 售出一张票，剩余票数{0}", sum);
                    }
                }
            }
        }

        public void Window3()
        {
            while (sum > 0)
            {
                Thread.Sleep(10);
                lock (objlock)
                {
                    if (sum > 0)
                    {
                        sum--;
                        w3++;
                        Console.WriteLine("窗口 3 售出一张票，剩余票数{0}", sum);
                    }
                }
            }
        }

        private static void Main(string[] args)
        {
            Program p = new Program();
            Thread tst1 = new Thread(new ThreadStart(p.Window1));
            Thread tst2 = new Thread(new ThreadStart(p.Window2));
            Thread tst3 = new Thread(new ThreadStart(p.Window3));
            tst1.Priority = ThreadPriority.Normal;
            tst2.Priority = ThreadPriority.Highest;
            tst3.Priority = ThreadPriority.Lowest;
            tst1.Start();
            tst2.Start();
            tst3.Start();
            Thread.Sleep(2000);
            Console.WriteLine("窗口 1 共售出{0}张票", w1);
            Console.WriteLine("窗口 2 共售出{0}张票", w2);
            Console.WriteLine("窗口 3 共售出{0}张票", w3);
            Console.WriteLine("一共售出{0}张票,剩余票数{1}", w1 + w2 + w3, sum);
        }
    }
}