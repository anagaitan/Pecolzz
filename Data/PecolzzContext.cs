using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pecolzz.Models;

namespace Pecolzz.Data
{
    public class PecolzzContext : DbContext
    {
        public PecolzzContext (DbContextOptions<PecolzzContext> options)
            : base(options)
        {
        }

        public DbSet<Pecolzz.Models.Produs> Produs { get; set; } = default!;

        public DbSet<Pecolzz.Models.Cod> Cod { get; set; }
    }
}
