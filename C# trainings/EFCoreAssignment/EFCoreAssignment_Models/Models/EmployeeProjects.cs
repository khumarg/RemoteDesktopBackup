using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment_Models.Models
{
    [Table("EmployeeProjects", Schema = "EFCoreAssignment")]
    public class EmployeeProjects
    {
        [ForeignKey("Employee")]
        public int EMPLOYEE_ID { get; set; }
        [ForeignKey("Projects")]
        public int ProjectID { get; set; }

        //Navigation Property
        public Employee Employee { get; set; }
        public Projects Projects { get; set; }
    }
}
