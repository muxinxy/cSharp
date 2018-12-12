using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            int edu,project=0;
            string number, name;
            Console.WriteLine("请输入学号：");
            number = Console.ReadLine();
            Console.WriteLine("请输入姓名：");
            name = Console.ReadLine();
            Console.WriteLine("请选择学历（1.本科  2.硕士  3.博士）：");
            edu = Convert.ToInt32(Console.ReadLine());
            while (edu!=1 && edu!=2 && edu!=3)
            {
                Console.WriteLine("请重新选择学历（1.本科  2.硕士  3.博士）：");
                edu = Convert.ToInt32(Console.ReadLine());
            }
            switch(edu)
            {
                case 1:Console.WriteLine("请选择课程（1.高等数学  2.大学物理）：");
                    project = Convert.ToInt32(Console.ReadLine());
                    break;
                case 2:Console.WriteLine("请选择课程（1.人工智能  2.数据挖掘）：");
                    project = Convert.ToInt32(Console.ReadLine());
                    break;
                case 3:Console.WriteLine("请选择课程（1.图像分析  2.远程控制）：");
                    project = Convert.ToInt32(Console.ReadLine());
                    break;
            }
            while(project!=1 && project!=2)
            {
                Console.WriteLine("请重新选择课程：");
                switch (edu)
                {
                    case 1:
                        Console.WriteLine("1.高等数学  2.大学物理");
                        project = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("1.人工智能  2.数据挖掘");
                        project = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("1.图像分析  2.远程控制");
                        project = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.WriteLine("学号：{0}", number);
            Console.WriteLine("姓名：{0}", name);
            switch (edu)
            {
                case 1:
                    Console.WriteLine("学历：本科");
                    if (project == 1)
                    {
                        Console.WriteLine("所选课程：高等数学");
                    }
                    else
                    {
                        Console.WriteLine("所选课程：大学物理");
                    }
                    break;
                case 2:
                    Console.WriteLine("学历：硕士");
                    if (project == 1)
                    {
                        Console.WriteLine("所选课程：人工智能");
                    }
                    else
                    {
                        Console.WriteLine("所选课程：数据挖掘");
                    }
                    break;
                case 3:
                    Console.WriteLine("学历：博士");
                    if (project == 1)
                    {
                        Console.WriteLine("所选课程：图像分析");
                    }
                    else
                    {
                        Console.WriteLine("所选课程：远程控制");
                    }
                    break;
            }
        }
    }
}
