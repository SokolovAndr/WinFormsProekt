using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WinFormsProekt.Models;

namespace WinFormsProekt
{
    public class AppContext : DbContext
    {
        public DbSet <Users> Users { get; set; }

        public AppContext() => Database.Migrate();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=WinFormsProekt.db");
        }
    }
}
