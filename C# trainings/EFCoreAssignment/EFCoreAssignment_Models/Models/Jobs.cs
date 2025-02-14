using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment_Models.Models
{
    [Table("Jobs", Schema = "EFCoreAssignment")]
    public class Jobs
    {
        [Key]
        [MaxLength(10)]
        public string JOB_ID { get; set; }

        [MaxLength(50)]
        [Required]
        public string JOB_TITLE { get; set; }

        public int MIN_SALARY { get; set; }
        public int MAX_SALARY { get; set; }


    }
}
