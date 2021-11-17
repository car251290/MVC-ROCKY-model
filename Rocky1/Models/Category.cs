﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky1.Models
{
    public class Category
    {
        [Key]

        public int Id { get; set;}

        public string Name { get; set; }

        public int DisplayOrder { get; set; }
    }
}
