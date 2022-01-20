using ConsoleApp18;
using System;

namespace ConsoleApp18
{
    abstract class Department
    {

        public void getDepartmentName()
        {
            Console.WriteLine("IT Department");
        }

        public void getNumberOfDepartment()
        {
            Console.WriteLine(" 2 ");
        }

        public virtual void getDepartmentDetail()
        {
            Console.WriteLine(" Team Leaders, Developer ");
        }
    }
}

class Employee : Department
{
    public void getFirstName()
    {
        Console.WriteLine(" Mohamed");
    }
    public void getLastName()
    {
        Console.WriteLine("Safeudeen");
    }

    public override void getDepartmentDetail()
    {
        Console.WriteLine(" Developers Team");
    }
}





 class Program
{
    static void Main(string[] args)
    {
        Employee d = new Employee();
        d.getDepartmentName();
        d.getNumberOfDepartment();
        d.getDepartmentDetail();
        d.getFirstName();
        d.getLastName();
    }
}


