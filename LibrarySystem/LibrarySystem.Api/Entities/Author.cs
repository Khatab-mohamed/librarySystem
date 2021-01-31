﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Api.Entities
{
    public class Author
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required] 
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required] 
        public DateTimeOffset DateOfBirth { get; set; }

        public ICollection<Book> Books { get; set; }


    }
}