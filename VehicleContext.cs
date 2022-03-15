using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRepairTracker
{
    public class VehicleContext : DbContext
    {
        public VehicleContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CarRepair;Trusted_Connection=True;");
        }

        // Puts vehicles in the database
        public DbSet<Vehicle> Vehicles { get; set; }


        // Puts Service Records in the database
        public DbSet<Services> Service { get; set; }

        public static SqlDataReader DataSource { get; internal set; }

    }
}
