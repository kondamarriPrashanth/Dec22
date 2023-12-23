using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            //a = a + b;
            //b = a - b;
            //a = a - b;
            a = a ^ b;
            b=a^b;
            a = a ^ b;
            Console.WriteLine("the value of a is" + a);
            Console.WriteLine("the value of b is"+ b);   

        }
    }
}
