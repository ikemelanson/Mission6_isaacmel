using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_isaacmel.Models
{
    public class MovieInfoContext : DbContext
    {
        public MovieInfoContext (DbContextOptions<MovieInfoContext> options) : base (options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MovieForm> responses { get; set; }

        //seed the database with three movies
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                    new Category
                    {
                        CategoryId = 1,
                        CategoryName = "Action/Adventure"
                    },
                    new Category
                    {
                        CategoryId = 2,
                        CategoryName = "Comedy"
                    },
                    new Category
                    {
                        CategoryId = 3,
                        CategoryName = "Drama"
                    },
                    new Category
                    {
                        CategoryId = 4,
                        CategoryName = "Family"
                    },
                    new Category
                    {
                        CategoryId = 5,
                        CategoryName = "Horrow/Suspense"
                    },
                    new Category
                    {
                        CategoryId = 6,
                        CategoryName = "Miscellaneous"
                    },
                    new Category
                    {
                        CategoryId = 7,
                        CategoryName = "Television"
                    },
                    new Category
                    {
                        CategoryId = 8,
                        CategoryName = "VHS"
                    }
                );

        mb.Entity<MovieForm>().HasData(
                new MovieForm
                {
                    ApplicationId = 1,
                    CategoryId = 1,
                    Title = "Italian Job, The",
                    Year = 2003,
                    DirectorFirstName = "Gary",
                    DirectoryLastName = "Gray",
                    Rating = "PG-13",
                    Edited = false
                }, 
                new MovieForm
                {
                    ApplicationId = 2,
                    CategoryId = 1,
                    Title = "Batman Begins",
                    Year = 2005,
                    DirectorFirstName = "Christopher",
                    DirectoryLastName = "Nolan",
                    Rating = "PG-13",
                    Edited = false
                },
                new MovieForm
                {
                    ApplicationId = 3,
                    CategoryId = 1,
                    Title = "The Fugitive",
                    Year = 1993,
                    DirectorFirstName = "Andrew",
                    DirectoryLastName = "Davis",
                    Rating = "PG-13",
                    Edited = false
                }
                );
        }
    }
}
