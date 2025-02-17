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
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> E)
        {
            E.HasKey(s=>s.ID);
            E.Property(c => c.Duration).IsRequired();
            E.Property(c => c.Name).IsRequired();
            E.Property(c => c.Description).IsRequired();
            E.HasKey(s=>s.Top_Id);
        }
    }
}
