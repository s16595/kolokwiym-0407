using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PoprawaKolos.Models
{
    public class Action
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAction { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        public bool NeedSpecialEquipment { get; set; }

        public ICollection<Firefighter> Firefighters { get; set; }
        public ICollection<FireTruck_Action> FireTruck_Actions { get; set; }

    }
}
