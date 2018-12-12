using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _9_3_xml
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlElement theBook = null, theElem = null, root = null;
            XmlDocument xml = new XmlDocument();
            xml.Load("D:\\cSharp\\9-3-xml\\Bookstore.xml");
            root = xml.DocumentElement;
            theBook = (XmlElement)root.SelectSingleNode("/bookstore/book[@category='CHILDREN']");
            theElem = xml.CreateElement("title");
            theElem.SetAttribute("lang", "ch");
            theElem.InnerText = "Huluwa";
            theBook.AppendChild(theElem);
            Console.WriteLine("添加成功！");
            XmlNodeList someBooks = root.SelectNodes("/bookstore/book[price<30]");
            for (int i = 0; i < someBooks.Count; i++)
            {
                someBooks.Item(i).ParentNode.RemoveChild(someBooks.Item(i));
            }
            Console.WriteLine("删除成功！");
            xml.Save("D:\\cSharp\\9-3-xml\\Bookstore.xml");
            Console.WriteLine("已保存！");
        }
    }
}
