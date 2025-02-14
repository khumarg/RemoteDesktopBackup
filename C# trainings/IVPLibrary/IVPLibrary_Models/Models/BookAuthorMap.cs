using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVPLibrary_Models.Models
{
    public class BookAuthorMap
    {
        [ForeignKey("Books")]
        public int BookID { get; set; }

        [ForeignKey("Author")]
        public int Author_Id { get; set; }

        //Navigation Property
        public Author Author { get; set; }
        public Books Books { get; set; }
    }
}
