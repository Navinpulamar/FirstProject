using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Day03
{
    internal class HashTable
    {

        public static void Main(string[] args)
        {
            SortedList table = new SortedList();
           // Hashtable table = new Hashtable();
            table.Add(12, "nave");
            table.Add(15, "vee");
            table.Add(13, "nae");
            table.Add(14, "een");

            //Accessing all key:value pairs
            foreach(var t in table.Keys)
            {
                Console.WriteLine($"key :{t} Value : {table[t]}");
            }
        }
    }
}
