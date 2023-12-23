using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec22
{
    internal class Ds
    {
        static void ListArrayf()
        {
            ArrayList ar= new ArrayList();
            ar.Add("hi");
            ar.Add("hlo");
            ar.Add("welcome");
            ar.Add("bye");
            ar.Add("bye");
            ar.Add("bye");
            ar.Add("bye");
            ar.Add("bye");
            ar.Add("bye");
            ar.Remove("hlo");
            ar.RemoveAt(0);
            //  ar.Clear();
            int c= ar.Count;
            Console.WriteLine(c);
            int cp = ar.Capacity;
            Console.WriteLine(cp);
            string[] sa = { "abc", "xyz" };
            ar.AddRange(sa);
            int li = ar.LastIndexOf("abc");
           Console.WriteLine(li);
            foreach(string i in ar)
            {
                Console.WriteLine(i);
            }

        }
        static void Main(string[] args)
        {
            ListArrayf();
        }
    }
}
