using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment_Models.Models
{
    [Table("EmployeeDetails", Schema = "EFCoreAssignment")]
    public class EmployeeDetails
    {
        [Key]
        public int EmployeeDetailsID { get; set; }

        [Required]
        [MaxLength(12)]
        public int Aadhaar { get; set; }

        public Employee Employee { get; set; }
        [ForeignKey("Employee")]
        public int EMPLOYEE_ID { get; set; }
    }
}
