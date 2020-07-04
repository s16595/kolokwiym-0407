using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PoprawaKolos.Models
{
    public class FireTruck
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFireTruck { get; set; }

        [MaxLength(10)]
        public string OpertaionalNumber { get; set; }

        public bool SpecialEquipment { get; set; }
    }
}
