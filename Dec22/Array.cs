using System;
//using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Markup;

namespace Dec22DSList
{
    //with using the temp variables 
    internal class Array
    {
        static void FunsArray()
        {
           
            int temp;
            int[] x = new int[] { 6, 45, 3, 22, 9 };
            Console.WriteLine("unsorted array is ");
            foreach (int i in x)
            { 
                Console.WriteLine("values is " + i);
            }
              Console.WriteLine("array ");
            Console.WriteLine("sorted array");
            for (int y = 0; y < x.Length - 1; y++)
            {
              for (int z = y+ 1; z < x.Length; z++)
                {
                    if (x[y] > x[z])
                    {
                        temp = x[y];
                        x[y] = x[z];
                        x[z] = temp;
                    }
                    Console.WriteLine();
                    foreach (int num in x) 
                    { 
                        Console.WriteLine(num);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            FunsArray();
            Console.ReadLine();
        }
    }
}
