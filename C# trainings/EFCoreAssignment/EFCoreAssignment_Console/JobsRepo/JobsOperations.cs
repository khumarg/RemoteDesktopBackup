using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreAssignment_DataAccess.Data;
using EFCoreAssignment_Models.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreAssignment_Console.JobsRepo
{
    public class JobsOperations : IJobs
    {
        public void FetchAllJobs()
        {
            using var context = new ApplicationDBContext();
            var jobs = context.Jobs.ToList();

            foreach (var job in jobs)
            {
                Console.WriteLine($"{job.JOB_ID} - {job.JOB_TITLE} - {job.MAX_SALARY} - {job.MIN_SALARY}");
            }
        }

        public void InsertJobs(Jobs job)
        {
            using var context = new ApplicationDBContext();
            context.Jobs.Add( job );
            context.SaveChanges();

            Console.WriteLine("New Job has been added with JobID = " + job.JOB_ID);
        }

        public void DeleteJobs(string jobID)
        {
            using var context = new ApplicationDBContext();

            var job = context.Jobs.Find(jobID);

            context.Jobs.Remove(job);
            context.SaveChanges();

            Console.WriteLine("Job has been deleted with jobID = " + job.JOB_ID);
        }

        public void UpdateJobs(string jobID)
        {
            using var context = new ApplicationDBContext();

            var job = context.Jobs.Find(jobID);
            job.MAX_SALARY = 1000000;
            context.SaveChanges();

            Console.WriteLine("Job has been updated.");
        }
    }
}
