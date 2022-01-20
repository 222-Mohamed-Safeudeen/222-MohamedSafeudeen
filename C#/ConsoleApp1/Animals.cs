using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Animals
    {
        public Animals()
        {
            Console.WriteLine("Animal Constructor");
        }
        public void Greet()
        {
            Console.WriteLine("Animals says hello");
        } 
        public void Talk()
        {
            Console.WriteLine("Animal Talk");
        }
        public virtual void Sing()
        {
            Console.WriteLine("Animal song");
        }
    }
    

    class Dog : Animals
    {
        public Dog()
        {
            Console.WriteLine("Dog COnstructor");
        }
        public override void Sing()
        {
            Console.WriteLine("Dog song");
        }
    }
}
