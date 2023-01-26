﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WishList.Models
{
    public class Item
    {
        public int Id { get; set; }

        public virtual ApplicationUser User { get; set; }

        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
    }
}
