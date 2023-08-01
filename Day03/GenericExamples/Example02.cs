using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExamples
{
    internal class Example02
    {
      
        public static void Main(string[] args)
        {
            Console.WriteLine("inside Example 02");
            Dictionary<int,string> dic = new Dictionary<int,string>();
            dic.Add(1,"apple");
            dic.Add(2, "banana");
            dic.Add(3,"mango");

            //iterate over dictionary
            foreach(int i in dic.Keys)
            {
                Console.WriteLine($"key : {i}  value : {dic[i]}");
            }

            //sorted dictionary
            //SortedDictionary<int,BankApp> s1 = new SortedDictionary<int,BankApp>();
            SortedList<int, BankApp> s1 = new SortedList<int, BankApp>();
            s1.Add(11, new BankApp(1234, "navin", "savings", 90));
            s1.Add(12, new BankApp(2375, "vinay", "current", 700));
            s1.Add(13, new BankApp(4512, "lavin", "savings",560));

            Console.WriteLine("Sorted Dictionary");
            //iterating over sorted dictionary
            foreach(int i in s1.Keys)
            {
                Console.WriteLine($"keys : {i} value : AccountNum : {s1[i].accountNum} Accountname :{s1[i].accountName} balance : {s1[i].balance}");
            }


            //sorted list
            


        }
    }
}
