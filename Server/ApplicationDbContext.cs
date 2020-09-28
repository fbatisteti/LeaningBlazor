using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningBlazor.Shared;

namespace LearningBlazor.Server
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        // this is to be done for each of our tables
        public DbSet<Good> Goods { get; set; }
    }
}
