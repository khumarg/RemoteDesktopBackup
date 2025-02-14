using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreAssignment_Console.JobsRepo;
using EFCoreAssignment_Models.Models;

namespace EFCoreAssignment_Console.Controller
{
    public class JobsController
    {
        IJobs _ijobs;

        public JobsController(IJobs ijobs)
        {
            _ijobs = ijobs;
        }

        public void FetchAllJobs()
        {
            _ijobs.FetchAllJobs();
        }

        public void InsertJob(Jobs jobs)
        {
            _ijobs.InsertJobs(jobs);
        }

        public void DeleteJob(string jobID)
        {
            _ijobs.DeleteJobs(jobID);
        }

        public void UpdateJob(string jobID)
        {
            _ijobs.UpdateJobs(jobID);
        }
    }
}
