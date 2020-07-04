using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoprawaKolos.Models
{
    public class TempModelDbContext : DbContext
    {

        public DbSet<TempModel> Temps { get; set; }

        public TempModelDbContext() { }

        public TempModelDbContext(DbContextOptions options) : base (options)
        {

        }
    }
}
