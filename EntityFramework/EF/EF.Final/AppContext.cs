using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Final
{
    public class AppContext : DbContext
    {
        // Объекты таблицы Users
        public DbSet<User> Users { get; set; }
        //public DbSet<Company> Companies { get; set; }
        // Объекты таблицы UserCredentials
        public DbSet<UserCredential> UserCredentials { get; set; }
        public AppContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=NORKA\SQLEXPRESS;Database=EF;Integrated Security = true;Trust Server Certificate=True;Trusted_Connection=True;");
        }
    }
}
