using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Entity;
using Demo.Entity.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Demo.Contexts
{
    // Microsoft.EntityFrameworkCore
    internal class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfigrationz());
            // modelBuilder.Entity<Employee>().HasKey("EmpId");
            // modelBuilder.Entity<Employee>().HasKey(nameof(Employee.Id));
            //modelBuilder.Entity<Employee>()
            //            .HasKey(n => n.Id);
            //modelBuilder.Entity<Employee>()
            //            .Property(p=>p.Name)
            //            .IsRequired()
            //            .HasColumnType("varchar")
            //            .HasMaxLength(50)
            //            .HasColumnName("EmployeeName");
            //modelBuilder.Entity<Employee>()
            //            .Property(p => p.Age)
            //            .IsRequired(false);
            //modelBuilder.Entity<Employee>()
            //            .Property(p => p.Salary)
            //            .HasColumnType("money");
            //modelBuilder.Entity<Employee>()
            //            .Property(p => p.dateTimeCreation)
            //            .HasDefaultValue(DateTime.Now);
            //modelBuilder.Entity<Employee>().Property(p => p.dateTimeCreation).HasDefaultValueSql("GETDATE()");
            //modelBuilder.Entity<Employee>(E =>
            //{
            //     E.HasKey(n => n.Id);
            //     E.Property(p => p.Name).IsRequired().HasColumnType("varchar").HasMaxLength(50).HasColumnName("EmployeeName");
            //     E.Property(p => p.Age).IsRequired(false);
            //     E.Property(p => p.Salary).HasColumnType("money");
            //     E.Property(p => p.dateTimeCreation).HasDefaultValueSql("GETDATE()");
            //});
            
            base.OnModelCreating(modelBuilder);
        }
        public AppDbContext():base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=YOUR_DATABASE_NAME;Trusted_Connection=True;");
        }
        public DbSet<Employee> employees { get; set; }
        

    }
}
