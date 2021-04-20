﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Role
    {
        public Role()
        {
        }
        public int Id { get; set; }
        [Required]
        public string RoleName { get; set; }

        public IList<User> Users { get; set; }
    }
}
