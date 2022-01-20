using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface Animal
    {
        void AnimalSound();
    }
    class cat : Animal
    {
        public void AnimalSound()
        {
            Console.WriteLine("The cat says : Meow Meow");
        }
    }
}

     
