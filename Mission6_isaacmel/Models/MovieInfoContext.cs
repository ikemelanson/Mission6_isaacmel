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

        public DbSet<MovieForm> responses { get; set; }

        //seed the database with three movies
        protected override void OnModelCreating(ModelBuilder mb)
        {
        mb.Entity<MovieForm>().HasData(
                new MovieForm
                {
                    ApplicationId = 1,
                    Category = "Action/Adventure",
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
                    Category = "Action/Adventure",
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
                    Category = "Action/Adventure",
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
