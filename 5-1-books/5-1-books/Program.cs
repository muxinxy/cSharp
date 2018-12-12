using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_books
{
    class Book
    {
        public string title;
        public string author;
        public double price;
        public int num;

        public Book() { }

        public Book(string title, string author, double price, int num)
        {
            this.title = title;
            this.author = author;
            this.price = price;
            this.num = num;
        }
        public void Display()
        {
            Console.WriteLine("标题：{0}  作者：{1}  价格：{2}  数量：{3}", title, author, price, num);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string title;
            string author;
            double price;
            int num;
            Console.Write("请输入标题：");
            title = Console.ReadLine();
            Console.Write("请输入作者：");
            author = Console.ReadLine();
            Console.Write("请输入价格：");
            price = Convert.ToDouble(Console.ReadLine());
            Console.Write("请输入数量：");
            num = Convert.ToInt32(Console.ReadLine());
            Book book = new Book(title,author,price,num);
            book.Display();
        }
    }
}
