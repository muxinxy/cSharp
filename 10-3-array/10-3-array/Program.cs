using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _10_3_array
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] a = new int[5];
                for (int i = 0; i <= 5; i++)
                {
                    a[i] = i;
                    Console.WriteLine(a[i]);
                }
            }
            catch (IndexOutOfRangeException i)
            {
                Console.WriteLine(i.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("End");
            }
        }
    }
}
