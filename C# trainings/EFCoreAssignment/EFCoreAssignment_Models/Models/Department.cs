using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment_Models.Models
{
    [Table("Departments", Schema = "EFCoreAssignment")]
    public class Department
    {
        [Key]
        public int DEPARTMENT_ID { get; set; }

        [MaxLength(30)]
        [Required]
        public string DEPARTMENT_NAME { get; set; }

        public Employee Managers { get; set; }
        [ForeignKey("Managers")]
        public int MANAGER_ID { get; set; }

    }
}
