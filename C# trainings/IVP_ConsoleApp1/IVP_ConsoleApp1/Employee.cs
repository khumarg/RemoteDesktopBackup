using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVP_ConsoleApp1
{
    internal class Employee
    {
        int id;
        string name;
        float salary;

        // Default Constructor
        public Employee()
        {
            id = 10;
            name = "Nikhil";
            salary = 500000f;
        }


        // Parameterized Constructor
        public Employee(int id, string name, float salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public Employee(string name, int id, float salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;

            //this --> current instance of a class
        }

        public void DisplayEmpDetails()
        {
            Console.WriteLine($"IVP Emp: {id} - {name} - {salary}");
        }

        ~Employee() { }  //Destructor

        //NOTE: we use Finalise and Dispose methods which work as a destructor while doing File Handling
        //      and ADO.NET


    }
}
