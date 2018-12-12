using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue(10);
            queue.Enqueue(1);
            queue.Enqueue(2);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Stack stack = new Stack();
            stack.Push(3);
            stack.Push(4);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Hashtable h = new Hashtable();
            h.Add(1001, 5);
            h.Add(1002, 6);
            h.Add(1003, 7);
            h.Remove(1002);
            Console.WriteLine(h[1001]);
            Console.WriteLine(h[1003]);
            ArrayList list = new ArrayList();
            list.Add(8);
            list.Remove(8);
        }
    }
}
