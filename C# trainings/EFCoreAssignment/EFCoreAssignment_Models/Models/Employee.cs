using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment_Models.Models
{
    [Table("Employees", Schema = "EFCoreAssignment")]
    public class Employee
    {
        [Key]
        public int EMPLOYEE_ID { get; set; }
        [Required]
        [MaxLength(20)]
        public string FIRST_NAME { get; set; }
        [MaxLength(25)]
        public string LAST_NAME { get; set; }
        [Required]
        [MaxLength(25)]
        public string EMAIL {  get; set; }
        public string PHONE_NUMBER { get; set; }
        [Required]
        public DateTime HIRE_DATE { get; set; }
        public double SALARY { get; set; }
        public double COMMISSION_PCT { get; set; }

        public Employee Managers { get; set; }
        [ForeignKey("Managers")]
        public int MANAGER_ID { get; set; }

        public Department Department { get; set; }
        [ForeignKey("Department")]
        public int DEPARTMENT_ID { get; set; }

        public Jobs Jobs { get; set; }

        [ForeignKey("Jobs")]
        [MaxLength(10)]
        public string JOB_ID { get; set; }

        public List<EmployeeProjects> EmployeeProjects { get; set; }
    }
}
