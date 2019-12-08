using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MicroService.Models
{
    public class MicroServiceContext : DbContext
    {
        public MicroServiceContext (DbContextOptions<MicroServiceContext> options)
            : base(options)
        {
        }

        public DbSet<MicroService.Models.SuveyModel> SuveyModel { get; set; }
    }
}
