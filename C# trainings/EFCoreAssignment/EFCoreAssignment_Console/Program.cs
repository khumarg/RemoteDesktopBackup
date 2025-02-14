using EFCoreAssignment_Console.Controller;
using EFCoreAssignment_Console.JobsRepo;
using EFCoreAssignment_Models.Models;

namespace EFCoreAssignment_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            IJobs jobs = new JobsOperations();
            JobsController control = new JobsController(jobs);


            // Fetch
            control.FetchAllJobs();

            // Insert
            Jobs job1 = new Jobs() { JOB_ID = "AC_ACCOUNT", JOB_TITLE = "Public Accountant", MAX_SALARY = 4200, MIN_SALARY = 9000 };
            Jobs job2 = new Jobs() { JOB_ID = "AC_MGR", JOB_TITLE = "Accounting Manager", MAX_SALARY = 8200, MIN_SALARY = 8200 };


            control.InsertJob(job1);
            control.InsertJob(job2);

            // Update
            //control.UpdateJob("AC_MGR");

            //// Delete
            //control.DeleteJob("AD_ASST");

            Console.ReadLine();
        }
    }
}
