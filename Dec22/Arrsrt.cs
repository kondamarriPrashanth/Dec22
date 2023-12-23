using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec22
{
    //By using the Sort() method
    internal class Arrsrt
    {
        static void f1()
        {
            int[] n = new int[] { 8, 6, 4, 2 };
            Console.WriteLine("values are unsorted");
            foreach (int i in n)
            {
                Console.WriteLine("values are not sorted {0}",i);
            }
            Array.Sort(n);
            Console.WriteLine("the sorted order is");
            foreach(int j in n)
            {
                Console.WriteLine("values are sorted {0}",j);
            }
        }
        static void Main(string[] args)
        {
            f1();
        }
    }
}
