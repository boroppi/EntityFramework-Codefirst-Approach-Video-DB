using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseCodeFirst.EntityConfigurations
{
    class GenreConfigurations : EntityTypeConfiguration<Genre>
    {
        public GenreConfigurations()
        {
            Property(g => g.Name)
                .IsRequired()
                .HasMaxLength(255);

         
        }
    }
}
