using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public static int IncomeTax { get; set; }

    

        public Employee()  //parameterless or default constructor
        {
            Id = 1;
            Name = "Rahul";
            Salary = 15000;
        }

        public Employee(int id, string name, int salary)  //parameterized constructor
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }

        public Employee(Employee emp)  //copy constructor,, accepting object of Employee type
        {
            this.Id = emp.Id;
            this.Name = emp.Name;
            this.Salary = emp.Salary;
        }



        public void Showdata()
        {
            Console.WriteLine("Id = " + this.Id);
            Console.WriteLine("Name = " + this.Name);
            Console.WriteLine("Salary = " + this.Salary);
        }




    }
}
