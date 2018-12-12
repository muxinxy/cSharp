using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_4_shape
{
    abstract class Shape
    {
        private double length;
        private double area;
        public virtual void Area()
        {
            Console.WriteLine("面积：{0}", area);
        }
    }
    class Triangle:Shape
    {
        public double length;
        private double area;
        public override void Area()
        {
            area = Math.Sqrt(3.0) * length * length / 4;
            Console.WriteLine("等边三角形面积：{0}", area);
        }
    }
    class Square : Shape
    {
        public double length;
        private double area;
        public override void Area()
        {
            area = length * length;
            Console.WriteLine("正方形面积：{0}", area);
        }
    }
    class Pantagon : Shape
    {
        public double length;
        private double area;
        public override void Area()
        {
            area = Math.Sqrt(3.0) * length * length / 4*5;
            Console.WriteLine("正五边形面积：{0}", area);
        }
    }
    class Hexagon : Shape
    {
        public double length;
        private double area;
        public override void Area()
        {
            area = Math.Sqrt(3.0) * length * length / 4*6;
            Console.WriteLine("正六边形面积：{0}", area);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int shape;
            double length;
            Triangle triangle = new Triangle();
            Square square = new Square();
            Pantagon pantagon = new Pantagon();
            Hexagon hexagon = new Hexagon();
            Console.WriteLine("请选择图形（1.正三角形  2.正方形  3.正五边形  4.正六边形）：");
            shape = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入边长：");
            length = Convert.ToDouble(Console.ReadLine());
            switch(shape)
            {
                case 1:triangle.length = length;
                    triangle.Area();
                    break;
                case 2:
                    square.length = length;
                    square.Area();
                    break;
                case 3:
                    pantagon.length = length;
                    pantagon.Area();
                    break;
                case 4:
                    hexagon.length = length;
                    hexagon.Area();
                    break;
            }
        }
    }
}
