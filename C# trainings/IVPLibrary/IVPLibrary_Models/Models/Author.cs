﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVPLibrary_Models.Models
{
    public class Author
    {
        [Key]
        public int Author_Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Location { get; set; }

        [NotMapped]
        public string FullName {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        // Navigation Property
        public List<Books> Books { get; set; }

        public List<BookAuthorMap> BookAuthorMap { get; set; }
    }
}
