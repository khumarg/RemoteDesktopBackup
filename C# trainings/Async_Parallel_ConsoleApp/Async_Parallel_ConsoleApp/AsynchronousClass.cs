using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_Parallel_ConsoleApp
{
    internal class AsynchronousClass
    {
        public static async Task Test()
        {
            Console.WriteLine("Test Started....");
            //Thread.Sleep(TimeSpan.FromSeconds(5));
            //await Task.Delay(TimeSpan.FromSeconds(5));
            //Console.WriteLine("\n");

            await Wait();
            Console.WriteLine("Test Ended");
        }

        public static async Task Wait()
        {
            Console.WriteLine("Wait Started");
            await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine("\n");
            Console.WriteLine("Wait Ended");
        }

        public async Task<string> GetCompany()
        {
            return "Indus Valley Partners";
        }

        public async Task<Employee> GetEmployeeDetails()
        {
            Employee emp = new Employee()
            {
                ID = 10,
                Name = "Nikhil",
                Salary = 1010000
            };

            return emp;
        }

        public async Task FetchInfo()
        {
            string cname = await GetCompany();
            Employee emp = await GetEmployeeDetails();

            Console.WriteLine($"{emp.ID} - {emp.Name} - {emp.Salary} - {cname}");
        }
    }
}
