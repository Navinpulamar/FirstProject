using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Day03
{
    internal class QueueExample
    {
        public static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            q.Enqueue(6);

            //how to convert this 
            //ToArray returns object 
          //  int[] arr = q.ToArray();

            //foreach(object o in arr)
            //{
            //    Console.WriteLine((int)o);
            //}

            //foreach(var item in q)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
