using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec22
{
    internal class Program1
    {
        List<Product> prodList;
        public Program1()
        {//object initilizer
            prodList = new List<Product>() {
            new Product(){Pid=1,Pname="soaps",Price=40},new Product(){ Pid=7,Pname="soft drink",Price=75}, new Product(){ Pid=10,Pname="masala",Price=55}, new Product(){Pid=9,Pname="toothpaste",Price=99 },new Product(){Pid=3,Pname="shampoo",Price=80 },new Product(){Pid=2,Pname="soups",Price=20 },new Product(){ Pid=4,Pname="dal",Price=33}
            };
            Product p = new Product()
            {
                Pid = Convert.ToInt32(Console.ReadLine()),
                Pname = Console.ReadLine(),
                Price = double.Parse(Console.ReadLine())
            };
            prodList.Add(p);

        }
        //write method t diplay all values, all records select *
        public List<Product> DisplayAll() { return prodList.ToList(); }
        public void DisplayById(int id)
        {
            Product onerow = prodList.Where(a => a.Pid == id).FirstOrDefault<Product>();
            if (onerow == null) { Console.WriteLine("no matching row"); } else { Console.WriteLine("display "); }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("please enter pid,pname,price");
            Program1 p = new Program1();// ctor is called and instance ready with all info
            Console.WriteLine("----------------------------------------------");
            var allProducts = p.DisplayAll();//non-static so object is required
            allProducts.ForEach(p1 => Console.WriteLine("product id {0}\tproduct name  {1}\tprice {2}", p1.Pid, p1.Pname, p1.Price));
            Console.WriteLine("-----------------------");
            Console.WriteLine("|");
            Console.WriteLine("enter you bank ac number");
            int no = int.Parse(Console.ReadLine());
            p.DisplayById(10);

        }
    }
}

    

