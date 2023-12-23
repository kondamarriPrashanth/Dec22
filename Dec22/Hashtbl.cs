using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec22
{
    internal class Hashtbl
    {
        static void TableHashFuns()
        {
            Hashtable ht1 = new Hashtable();
            ht1.Add(1000, "abc");//key,value
            ht1.Add(1, "xyz");
            ht1.Add(45, "world");
            // ht1.Remove(45);// remove is by key not value
            //  ht1.Clear();
            // access by key
            ICollection allKeys = ht1.Keys;
            foreach (var item in allKeys)
            {
                Console.WriteLine("key is " + item);
            }
            ICollection allValues = ht1.Values;
            foreach (string str in allValues) { Console.WriteLine("values are " + str); }
            // both in one object is dictonaryEntry is Special collection
            foreach (DictionaryEntry de in ht1)
            {
                Console.WriteLine("key is " + de.Key);
                Console.WriteLine("values " + de.Value);
            }
            //serach
            bool b1 = ht1.Contains(1);//  takes key 
            Console.WriteLine(b1);
            bool b2 = ht1.ContainsKey(45);
            Console.WriteLine(b2);
            bool b3 = ht1.ContainsValue("xyz");
            Console.WriteLine(b3);
            string[] strArr = { "abc", "xyz" };
            //ht1.CopyTo(strArr, 1);// ft=rom hashtable to array values are copied 
            //key is used to search as indentity     
            // HashTable is Complex DS in non-sequence catogery

        }
        static void Main(string[] args)
        {
            TableHashFuns();
        }

    }
}
