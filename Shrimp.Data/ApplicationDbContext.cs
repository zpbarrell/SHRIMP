using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shrimp.Data.Entities;

namespace Shrimp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
            public DbSet<DistrictEntity> Districts { get; set; }
            public DbSet<SchoolEntity> Schools { get; set; }
            
    }
    
}