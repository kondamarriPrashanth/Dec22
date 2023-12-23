using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec22
{
    internal class EmpDataClass
    {
       static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>()
            {
new Employee(){Eid=10,EFname="Amit",ELname="bill",Address="Hyd",Salary=9090},
new Employee(){ Eid=14,EFname="tim",ELname="mohit",Address="chennai",Salary=7070},new Employee(){Eid = 13, EFname = "ronaldo", ELname = "robert", Address = "NY", Salary = 6565},
new Employee(){Eid=11,EFname="Jerry",ELname="Gerald",Address="NJ",Salary=8787},
new Employee(){Eid=12,EFname="Sandra",ELname="Julia",Address="CA",Salary=8585},
new Employee() { Eid = 16, EFname = "Rajesh", ELname = "Sowmya", Address = "Ban", Salary = 7878 }
            };// object initializer values are also assigned
            // each record all data 
           // foreach (var onerow in empList)
            {// C#.net we are doing 
             // Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",onerow.Eid,onerow.EFname,onerow.ELname,onerow.Address,onerow.Salary);
            }
            // linq way with list  to display all records select * 
          //  var allemps = empList.ToList();
            empList.ToList().ForEach(e1 => Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", e1.Eid, e1.EFname, e1.ELname, e1.Address, e1.Salary));
            var id= from e2 in empList where e2.Eid == 10 select e2;
            //select * from collection where eid=10
            foreach (var x in id) { Console.WriteLine(x.Eid + "  " + x.Salary); }
            var Name = from e3 in empList where e3.ELname == "amit" select e3;
            foreach (var x in Name) { Console.WriteLine(x.Eid + "  " + x.Salary); }



        }//e1 is any variable we use which is dynamic object presents a row 
         //=> lambda operator left side variable is input variable 
         // display by name or by id 

    }
}

    

