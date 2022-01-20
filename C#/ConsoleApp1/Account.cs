using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class AccountClass
    {
        public AccountClass()
        {
            Console.WriteLine(" Account constructor ");
        }
        public void Number()
        {
            Console.WriteLine("50010000");
        }
        public void Ifsc()
        {
            Console.WriteLine("IOBA22322");
        }
        public virtual void Adress()
        {
            Console.WriteLine("Tamilnadu");
        }
    }
    class Customer : AccountClass
    {
        public Customer()
        {
            Console.WriteLine("Customer Name");
        }
        public override void Adress()
        {
            Console.WriteLine("Nagpattinam");
        }
    }
        

}
