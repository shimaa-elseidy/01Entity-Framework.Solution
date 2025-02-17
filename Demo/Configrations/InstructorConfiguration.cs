using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Demo.Entity.ITIClasses;

namespace Demo.Configrations
{
    internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> E)
        {
            E.HasKey(c => c.ID);
            E.Property(c => c.Name).IsRequired();
            E.Property(c => c.Bonus).IsRequired();
            E.Property(c => c.HourRate).IsRequired();
            E.Property(c => c.HourRate).IsRequired();
            E.Property(c => c.Address).IsRequired();
            E.Property(c => c.Salary).IsRequired();
            E.Property(c => c.DeptID).IsRequired();
        }
    }
}
