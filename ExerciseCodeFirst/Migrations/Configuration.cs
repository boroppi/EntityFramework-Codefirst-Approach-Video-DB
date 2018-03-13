using System.Data.Entity.Migrations;

namespace ExerciseCodeFirst.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<VidzyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(VidzyContext context)
        {
            context.Genres.AddOrUpdate(g => g.Name, new Genre
            {
                Id = 1,
                Name = "Action"
            }, new Genre
            {
                Id = 2,
                Name = "Sci-fi"
            }, new Genre
            {
                Id = 3,
                Name = "Drama"
            });
        }
    }
}
