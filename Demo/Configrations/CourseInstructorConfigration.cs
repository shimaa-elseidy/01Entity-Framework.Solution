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
    internal class CourseInstructorConfigration : IEntityTypeConfiguration<CourseInstructor>
    {
        public void Configure(EntityTypeBuilder<CourseInstructor> E)
        {
            E.HasKey(E =>  new {E.InsID , E.CourseId});
            E.Property(c => c.Evaluate).IsRequired();
        }
    }
}
