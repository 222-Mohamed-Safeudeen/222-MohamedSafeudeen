using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //public class Animal
    //{
    //    public Animal() // the name of the constructor is the name of the class
    //    {

    //    }

    //    public void MakeNoise()
    //    {
    //        Console.WriteLine("Animal Makes a Noise");
    //    }
    //}
    public class Employee
    {
        public Employee()
        {
            
        }
        public void GetName()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            string age = Console.ReadLine();
            Console.WriteLine("your name is " + name);
            Console.WriteLine("your age is " + age);



        }
    }
}