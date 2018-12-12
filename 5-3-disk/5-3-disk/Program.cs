using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_disk
{
    class Disk
    {
        private double size;

        public virtual void Add(double space)
        {
            size -= space;
        }
        public virtual void Del(double space)
        {
            size += space;
        }
    }

    class HardDisk:Disk
    {
        private double size;

        public HardDisk(double size)
        {
            this.size = size;
        }

        public override void Add(double space)
        {
            size -= space;
            Console.WriteLine("硬盘剩余空间：{0}", size);
        }
        public override void Del(double space)
        {
            size += space;
            Console.WriteLine("硬盘剩余空间：{0}", size);
        }
    }

    class Flash : Disk
    {
        private double size;

        public Flash(double size)
        {
            this.size = size;
        }

        public override void Add(double space)
        {
            size -= space;
            Console.WriteLine("闪盘剩余空间：{0}", size);
        }
        public override void Del(double space)
        {
            size += space;
            Console.WriteLine("闪盘剩余空间：{0}", size);
        }
    }

    class CDROM : Disk
    {
        private double size;

        public CDROM(double size)
        {
            this.size = size;
        }

        public override void Add(double space)
        {
            size -= space;
            Console.WriteLine("光盘剩余空间：{0}", size);
        }
        public override void Del(double space)
        {
            size += space;
            Console.WriteLine("光盘剩余空间：{0}", size);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int disk,op;
            double file;
            HardDisk hardDisk = new HardDisk(100);
            Flash flash = new Flash(100);
            CDROM cDROM = new CDROM(100);
            Console.WriteLine("请选择磁盘（1.硬盘 2.闪盘 3.光盘）：");
            disk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请选择操作（1.写入 2.删除）：");
            op = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入文件大小：");
            file = Convert.ToDouble(Console.ReadLine());
            switch (disk)
            {
                case 1:if (op == 1)
                        hardDisk.Add(file);
                    else hardDisk.Del(file);
                    break;
                case 2:
                    if (op == 1)
                        flash.Add(file);
                    else flash.Del(file);
                    break;
                case 3:
                    if (op == 1)
                        cDROM.Add(file);
                    else cDROM.Del(file);
                    break;
            }
        }
    }
}
