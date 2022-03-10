using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRepairTracker
{
    internal class ServiceContext : DbContext
    {
        public ServiceContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CarRepair;Trusted_Connection=True;");
        }

        // Puts vehicles in the database
        public DbSet<Services> Service { get; set; }
    }
}
