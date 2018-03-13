using System.Data.Entity;
using ExerciseCodeFirst.EntityConfigurations;

namespace ExerciseCodeFirst
{
    public class VidzyContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public VidzyContext()
            : base("name=DefaultConnection")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GenreConfigurations());
            modelBuilder.Configurations.Add(new VideoConfigurations());
            base.OnModelCreating(modelBuilder);
        }
    }
}