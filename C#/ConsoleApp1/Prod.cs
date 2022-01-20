using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
     public class Prod : Iproduct
    {
        public string GetProductName()
        {
            return "Nutella ";
        }

        public string GetProductPrice()
        {
            return "300/-";

        }
    }
}
