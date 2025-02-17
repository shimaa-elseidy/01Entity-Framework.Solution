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
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> E)
        {
            E.HasKey(c => c.ID);
            E.Property(c => c.HiringDate).IsRequired();
            E.Property(c => c.Name).IsRequired();
            E.Property(c => c.Ins_Id).IsRequired();
        }
    }
}
