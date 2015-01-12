namespace MvcMovie.Migrations
{
    using MvcMovie.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovie.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcMovie.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title,
                new Movie
                {
                    Title = "Blade Runner",
                    ReleaseDate = DateTime.Parse("1982-6-25"),
                    Genre = "Sci-Fi | Thriller",
                    Price = 19.99M
                },

                new Movie
                {
                    Title = "Gladiator",
                    ReleaseDate = DateTime.Parse("2000-5-5"),
                    Genre = "Action | Drama",
                    Price = 19.99M
                },

                new Movie
                {
                    Title = "Pride $ Prejudice",
                    ReleaseDate = DateTime.Parse("2005-11-23"),
                    Genre = "Drama | Romance",
                    Price = 14.99M
                },

                new Movie
                {
                    Title = "Tron: Legacy",
                    ReleaseDate = DateTime.Parse("2010-12-17"),
                    Genre = "Action | Adventure | Sci-Fi",
                    Price = 22.99M
                }

        );
        }
    }
}
