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
    internal class StudentCourseConfiguration : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> E)
        {
            E.HasKey(E => new {E.StudID , E.CourseId } );
            E.Property(E=> E.Grade ).IsRequired();
        }
    }
}
