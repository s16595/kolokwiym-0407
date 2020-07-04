﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoprawaKolos.Models
{
    public class TempModel
    {

        public int Id { get; set; }


        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
    }
}
