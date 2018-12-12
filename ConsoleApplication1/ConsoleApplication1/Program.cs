using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "C:\\Program\\Work\\Test.cs";
            string disk,filename;
            int i;
            i = str.IndexOf(':');
            disk = str.Substring(0,i);
            disk = str.Remove(i, str.Length - i);
            Console.WriteLine(disk);
            string[] latter = str.Split('.');
            i = latter[0].LastIndexOf('\\');
            filename = latter[0].Substring(i+1);
            filename = latter[0].Remove(0,i+1);
            Console.WriteLine(filename);
            Console.WriteLine(latter[1]);
        }
    }
}
