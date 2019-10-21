using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DatingAppContext : DbContext
    {
        public DatingAppContext(DbContextOptions dbContextOptions): base(dbContextOptions) {}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public DbSet<Values> Values { get; set; }
    }
}
