using Abtestreal.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Abtestreal.DAL.EF
{
   public class UserRegContext:DbContext
    {

        public DbSet<UserRegDal> Users { get; set; }

        public UserRegContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=abtestrealtst;Trusted_Connection=True;");
        }
    }
}
