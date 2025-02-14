using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVPLibrary_Models.Models
{
    //[Table("Books", Schema = "sales")]
    public class Books
    {
        [Key]
        public int BookID { get; set; }

        [MaxLength(100)]
        [Required]
        public string Title { get; set; }

        [Required]
        [MaxLength(50)]
        public string ISBN { get; set; }
        public decimal Price { get; set; }

        [NotMapped]         // will be excluded in the database
        public decimal Discount { set { Discount = 0.1m; } }

        //Navigation Property
        public BookDetails BookDetails { get; set; }

        //Navigation Property
        public Publisher Publisher { get; set; }

        [ForeignKey("Publisher")]
        public int Publisher_Id { get; set; }

        //Navigation Property
        public List<Author> Author { get; set; }

        public List<BookAuthorMap> BookAuthorMap { get; set; }


        //[ForeignKey("BookDetails")]
        //public int BookDetails_Id { get; set; }
    }
}
