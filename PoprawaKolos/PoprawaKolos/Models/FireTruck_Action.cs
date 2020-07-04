using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PoprawaKolos.Models
{
    public class FireTruck_Action
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFireTruckAction { get; set; }
        public DateTime AssigmentDate { get; set; }




        [ForeignKey("FireTruck")]
        public int IdFireTruck { get; set; }
        public FireTruck FireTruck { get; set; }


        [ForeignKey("Action")]
        public int IdAction { get; set; }
        public Action Action { get; set; }

    }
}
