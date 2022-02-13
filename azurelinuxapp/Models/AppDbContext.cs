using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace azurelinuxapp.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book()
                {
                    Id = 1,
                    Name = "Python",
                    description = "this book covers information about core python and python db",
                    cost = 575.45
                },
                   new Book()
                   {
                       Id = 2,
                       Name = "Java",
                       description = "this book covers information about core java and jdbc",
                       cost = 575.45
                   },
                      new Book()
                      {
                          Id = 3,
                          Name = "C#",
                          description = "this book covers information about core C# and some dotnet technologies",
                          cost = 575.45
                      });
        }
    }
}
