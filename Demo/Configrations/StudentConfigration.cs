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
    internal class StudentConfigration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> E)
        {
            E.HasKey(s => s.ID);
            E.Property(s => s.FName).IsRequired();
            E.Property(s => s.LName).IsRequired();
            E.Property(s => s.Address).IsRequired();  
            E.Property(s => s.Age).IsRequired();
            E.Property(s => s.Dep_Id);
        }
    }
}
