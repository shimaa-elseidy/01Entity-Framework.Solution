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
    internal class TopicConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> E)
        {
            E.HasKey(c => c.ID);
            E.Property(c => c.Name).IsRequired();
        }
    }
}
