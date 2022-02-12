using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BrodnikProject.Models;

namespace BrodnikProject.Data
{
    public class BrodnikProjectContext : DbContext
    {
        public BrodnikProjectContext (DbContextOptions<BrodnikProjectContext> options)
            : base(options)
        {
        }

        public DbSet<BrodnikProject.Models.Player> Player { get; set; }

        public DbSet<BrodnikProject.Models.Schedule> Schedule { get; set; }

        public DbSet<BrodnikProject.Models.Stat> Stat { get; set; }
    }
}
