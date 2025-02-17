using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Entity.Configurations
{
    internal class EmployeeConfigrationz : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> E)
        {
                E.HasKey(n => n.Id);
                E.Property(p => p.Name).IsRequired().HasColumnType("varchar").HasMaxLength(50).HasColumnName("EmployeeName");
                E.Property(p => p.Age).IsRequired(false);
                E.Property(p => p.Salary).HasColumnType("money");
                E.Property(p => p.dateTimeCreation).HasDefaultValueSql("GETDATE()");
        }
    }
}
