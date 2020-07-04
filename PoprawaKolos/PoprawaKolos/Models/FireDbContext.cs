using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoprawaKolos.Models
{
    public class FireDbContext : DbContext
    {

        public DbSet<Firefighter> Firefighters { get; set; }
        public DbSet<FireTruck> FireTrucks { get; set; }
        public DbSet<FireTruck_Action> FireTruck_Actions { get; set; }
        public DbSet<Action> Actions { get; set; }

        public FireDbContext() { }

        public FireDbContext(DbContextOptions options) : base(options)
        {

        }


    }
}
