namespace Day03
{
    interface Imobile
    {
        void M1() { }
        void discount() { }
    }

    interface Ilaptop
    {
        void M2() { }
        void discount() { }
    }

    internal class Ecommerce : Imobile, Ilaptop
    {
        public void M1()
        {
            Console.WriteLine("Imoblie method");
        }

        public void M2()
        {
            Console.WriteLine("Ilaptop method");
        }

        //explicit implementation, for this there is no need of public or any modifier
       
        void Imobile.discount()
        {
            Console.WriteLine("Imoblie discount");
        }

        void Ilaptop.discount()
        {
            Console.WriteLine("Ilaptop discount");
        }
    }
    internal class Program
    {
        //interface Ibank
        //{
        //     void openAccount();
        //     void closeAccount();
        //}

        //internal class Bank : Ibank
        //{
        //    public void openAccount()
        //    {
        //        Console.WriteLine("Opened account in ICIC");
        //    }

        //    public void closeAccount()
        //    {
        //        Console.WriteLine("Closed account in ICIC");
        //    }

        //    public void deleteAccount()
        //    {
        //        Console.WriteLine("delete account permenently");
        //    }
        //}

       
        static void Main(string[] args)
        {
            //Topic 01 : Interfaces
            //Ibank b = new Bank();
            //b.openAccount();
            //b.closeAccount();

            //Topic 02 : multiple inheritance

            Imobile e = new Ecommerce();
            e.discount();
            
        }
    }
}