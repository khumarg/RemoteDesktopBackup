using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVPLibrary_Models.Models
{
    public class Publisher
    {
        [Key]
        public int Publisher_Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }
    }
}
