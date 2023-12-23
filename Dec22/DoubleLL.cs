using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec22
{
    internal class DoubleLL
    {
        static void DoubleLLfun()
        {
            LinkedList<string> ll = new LinkedList<string>();
            ll.AddLast("a");
            ll.AddLast("b");
            ll.AddFirst("c");
            ll.AddFirst("d");
            ll.AddBefore(ll.Last, "Julia");
            ll.RemoveFirst();
            ll.RemoveLast();
            // display how they got added
            foreach (var v in ll)
            {
                Console.WriteLine(v);
            }
           // ll.CopyTo("string array",indexno) //from LL values are copied to array         
            // remove
            //ll.RemoveFirst();
             //ll.RemoveLast();
           Console.WriteLine("trying to rmove xyz not part of LL");
              // ll.Remove("xyz");// no exception is raised 
            bool b1 = ll.Contains("xyz");//search for values then check if condition
            if (b1.Equals(true)) {
                Console.WriteLine("Yes Xyz ");
                ll.Remove("xyz"); 
            } 
            else
            { 
                Console.WriteLine("values is not in the list");
            }
            //  Console.WriteLine("done ");
            //ll.Remove(ll.Last);
              //ll.Remove(ll.First);

        }
        static void Main(string[] args)
        {
            // ListArrayFuns();
            DoubleLLfun();
            Console.ReadLine();

        }
    }
}

    

