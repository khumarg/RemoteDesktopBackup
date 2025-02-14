using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLibraryModels.Models
{
    [Table("BooksTest")]
    public class Book
    {
        [Key]
        public int BookID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        public string ISBN { get; set; }

        public decimal Price { get; set; }

        [NotMapped]
        public float Discount { set { Discount = 0.1f; } }
    }
}
