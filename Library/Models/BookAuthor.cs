﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    [Table("BookAuthor")]
    public class BookAuthor
    {
        [Key]
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}