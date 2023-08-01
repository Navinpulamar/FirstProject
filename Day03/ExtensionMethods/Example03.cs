using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{

    internal class Employee
    {
        public void display()
        {
            Console.WriteLine("sdf");
        }
    }

    internal class Example03
    {
        public static void Main(String[] args)
        {
            //This for integer extension
            int a = 23;
            if (a.isEven())
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }


            //checking object is null or not
            Employee emp = new Employee();
            //emp.isNull() ? "obj is null" : "obj is not null";
            if(emp.isNull())
            {
                Console.WriteLine("Object is null");
            }
            else
            {
                Console.WriteLine("Object is not null");
            }



        }


    }


}
