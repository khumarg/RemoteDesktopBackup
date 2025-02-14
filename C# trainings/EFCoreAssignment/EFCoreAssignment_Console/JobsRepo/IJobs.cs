using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreAssignment_Models.Models;

namespace EFCoreAssignment_Console.JobsRepo
{
    public interface IJobs
    {
        public void FetchAllJobs();
        public void InsertJobs(Jobs jobs);
        public void DeleteJobs(string jobID);
        public void UpdateJobs(string jobID);
    }
}
