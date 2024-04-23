using System;
using Microsoft.EntityFrameworkCore;

namespace NetStarter.Basics.DataAccess
{
   public class BasicDbContext : DbContext
   {
      public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=College.db");
        }

   }
}