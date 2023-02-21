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
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            //Adds in linking field for our two tables but lets people see the category name, not id
            mb.Entity<Category>().HasData(
                new Category { CategoryID=1, CategoryName="Action"},
                new Category { CategoryID=2, CategoryName="Comedy"},
                new Category { CategoryID = 3, CategoryName = "Drama" },
                new Category { CategoryID = 4, CategoryName = "Horror" },
                new Category { CategoryID = 5, CategoryName = "Animated" },
                new Category { CategoryID = 6, CategoryName = "Children's" },
                new Category { CategoryID = 7, CategoryName = "Romance" }
            );

            mb.Entity<MovieForm>().HasData(

                //Database seed
                new MovieForm
                {
                    MovieID = 1,
                    CategoryID = 7,
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
                    CategoryID = 6,
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
                    CategoryID = 2,
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
