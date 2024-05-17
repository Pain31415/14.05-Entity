using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace SportsContext
{
    public class SportsContext : DbContext
    {
        public DbSet<SportsTeam> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SportsDb;Trusted_Connection=True");
        }
    }
}