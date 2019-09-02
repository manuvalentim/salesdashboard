using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebDashboard.Models
{
    public class SalesWebDashboardContext : DbContext
    {
        public SalesWebDashboardContext (DbContextOptions<SalesWebDashboardContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebDashboard.Models.Department> Department { get; set; }
    }
}
