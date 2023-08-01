using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices;

namespace Day03
{
    internal class Products : IComparable
    {
        public int Pid { get; set; }
        public string Pname;
        public double price;
        public string stock;


        public Products(int pid, string pname, double price, string stock)
        {
            Pid = pid;
            Pname = pname;
            this.price = price;
            this.stock = stock;
        }

        public int CompareTo(object obj)
        {
            return Pid.CompareTo(((Products)obj).Pid);
        }

    }
    internal class Productcs 
    {
        public static void Main(string[] args)
        {
            Products p1 = new Products(12,"shampoo",21,"in");
            Products p2 = new Products(13, "shampoo", 20, "in");
            Products p3 = new Products(14, "shampoo", 1, "in");
            Products p4 = new Products(15, "shampoo", 17, "in");
            Products p5 = new Products(16, "shampoo", 2, "in");
            ArrayList arr = new ArrayList();
            arr.Add(p1);
            arr.Add(p2);
            arr.Add(p3);
            arr.Add(p4);
            arr.Add(p5);

            Products p = arr[2] as Products;
            arr.Sort();
            foreach(Products ob in arr)
            {
                Console.WriteLine($"Pid = {ob.Pid}  Pname : {ob.Pname} Price : {ob.price}");
            }

        }
    }
}
