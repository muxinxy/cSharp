using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] number1 = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            int j=0;
            foreach (int i in number1)
            {
                Console.Write(i +  "\t");
                j++;
                if (j % 4 == 0)
                    Console.Write('\n');
            }
            int[,] number2 = new int[3, 4];
            for(int m=0;m<3;m++)
            {
                for(int n=0;n<4;n++)
                {
                    string input = Console.ReadLine();
                    number2[m, n] = Convert.ToInt32(input);
                }
            }
            j = 0;
            foreach (int i in number2)
            {
                Console.Write(i + "\t");
                j++;
                if (j % 4 == 0)
                    Console.Write('\n');
            }
        }
    }
}
