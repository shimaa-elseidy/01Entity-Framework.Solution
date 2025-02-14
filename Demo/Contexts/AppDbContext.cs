using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Entity;
using Microsoft.EntityFrameworkCore;

namespace Demo.Contexts
{
    // Microsoft.EntityFrameworkCore
    internal class AppDbContext : DbContext
    {
        public AppDbContext():base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = AppG03 ; Trusted_Connection = True");
        }
        public DbSet<Employee> employees { get; set; }

    }
}
