using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    internal class StackExamplecs
    {
        public static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            stack.Push(9);
            //stack.Push("peek "+ stack.Peek());
            int[] arr = stack.ToArray();
            
            //after converted to arr
            foreach(int a in arr)
            {
                Console.WriteLine(a);
            }
            
            //foreach(var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
