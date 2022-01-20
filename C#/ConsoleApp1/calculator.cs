using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   public  class calculator
    {
        public void Add(int x ,  int y)
        {
            int addition = x + y;
            Console.WriteLine("The sum of x,y is" + addition );
        }
        public int Sub(int x , int y)
        {
            return x - y;
        }
        public int Mul(int x, int y)
        {
            return x * y;
        }
        public int Div(int x, int y)
        {
            return x * y;
        }
    }
}
