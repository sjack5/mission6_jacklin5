using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission6_jacklin5.Models
{
    public class MoviesContext: DbContext
    {
        //Constructor
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options)
        {
            //Leave blank for now
        }

        public DbSet<MovieForm> Movie { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieForm>().HasData(

                new MovieForm
                {
                    MovieID = 1,
                    Category = "Romance",
                    Title = "The Princess Bride",
                    Year = 1987,
                    Director = "Rob Reiner",
                    Rating = "PG",
                    Edited = false,
                    Lent = " ",
                    Notes = "This is a great film!"
                },
                new MovieForm
                {
                    MovieID = 2,
                    Category = "Animated, Comedy",
                    Title = "Boss Baby",
                    Year = 2017,
                    Director = "Tom McGrath",
                    Rating = "PG",
                    Edited = false,
                    Lent = "Brady Jacklin",
                    Notes = "Too many baby bums"
                },
                new MovieForm
                {
                    MovieID = 3,
                    Category = "Animated, Comedy",
                    Title = "Mr. Peabody and Sherman",
                    Year = 2014,
                    Director = "Rob Minkoff",
                    Rating = "PG",
                    Edited = false,
                    Lent = "Kimball Shupe",
                    Notes = "The greatest film in history"
                }
            );
        }
    } 
}
