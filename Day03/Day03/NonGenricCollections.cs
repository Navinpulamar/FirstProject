using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Day03
{
    internal class NonGenricCollections
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("sdfsdf");
            ArrayList arr = new ArrayList() { 23,1,56,89,2,34,67,12};
            ArrayList arr2 = new ArrayList() { "hello", "bye", "tata", "good" };
            ArrayList arr3 = new ArrayList();

            //operations
            arr3.Add(1);
            arr3.Add(2);
            arr3.Add(3);
            arr3.Add(4);
            arr3.Add(5);
            arr3.Insert(2,34);
            arr3.Remove(34);
            int n = 23;
            Boolean flag = false;

            foreach(var a in arr3)
            {
                if((int)a == n)
                {
                    flag = true;
                    Console.WriteLine("element found");
                }
                Console.WriteLine(a);
            }

            if(flag == false)
            {
                Console.WriteLine("element not found");
            }


            //sort
            arr2.Sort();
            foreach(var a in arr2)
            {
                Console.WriteLine((string)a);
            }

            //binary serach
            int f = arr2.BinarySearch("jhkjhk");
            if (f != 0)
            {
                Console.WriteLine("found" + f);
            }
            else
            Console.WriteLine("not found");
            
        }
    }
}
