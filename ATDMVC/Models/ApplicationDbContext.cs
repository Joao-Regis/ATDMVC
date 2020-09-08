using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATDMVC.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Request> Requests { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Rack> Racks { get; set; }

        public DbSet<RackType> RackTypes { get; set; }

        public DbSet<Repair> Repairs { get; set; }
    }
}
