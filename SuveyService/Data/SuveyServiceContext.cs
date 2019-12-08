using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SuveyService.Models
{
    public class SuveyServiceContext : DbContext
    {
        public SuveyServiceContext (DbContextOptions<SuveyServiceContext> options)
            : base(options)
        {
        }

        public DbSet<SuveyService.Models.Suvey> Suvey { get; set; }
    }
}
