using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace GenericExamples
{

    //This is list example
    internal class BankApp : IComparable<BankApp>
    {
        //creating bank example
        public int accountNum;
        public string accountName;
        public string accountType;
        public int balance;

        //constructor
        public BankApp(int accountNum, string accountName, string accountType, int balance)
        {
            this.accountNum = accountNum;
            this.accountName = accountName;
            this.accountType = accountType;
            this.balance = balance;
        }

        //by using account number we are sorting
        public int CompareTo(BankApp obj)
        {
            return accountNum.CompareTo(obj.accountNum);
        }
    }
    internal class Example1
    {
        
        public static void Main(string[] args)
        {
            List<BankApp> list = new List<BankApp>();
            list.Add(new BankApp(1234,"nave","savings",120));
            list.Add(new BankApp(1234, "nave", "savings", 120));
            list.Add(new BankApp(1234, "nave", "savings", 120));
            list.Add(new BankApp(1234, "nave", "savings", 120));
            list.Add(new BankApp(1234, "nave", "savings", 120));
            list.Add(new BankApp(1234, "nave", "savings", 120));

            Console.WriteLine("hello");
            //foreach(BankApp l in list)
            //{
            //    Console.WriteLine(l.ToString());
            //}
        }
    }

}
