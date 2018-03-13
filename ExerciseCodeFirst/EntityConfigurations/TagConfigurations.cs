using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseCodeFirst.EntityConfigurations
{
    class TagConfigurations : EntityTypeConfiguration<Tag>
    {
        public TagConfigurations()
        {
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
