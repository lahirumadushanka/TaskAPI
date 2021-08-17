using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskAPI.Models;

namespace TaskAPI.DatabaseAccess
{
    public class TodoDBContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=DESKTOP-8KUOT0J; Database=MyTodoDb; " +
                "integrated security=SSPI; Trusted_Connection=True; MultipleActiveResultSets=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author {Id = 1, FullName="Lahiru Madushanka", AddressNo= "No 260/8", Street="Ginigallanda", City="Hungama", JobRole = "Developer" },
                new Author { Id = 2, FullName = "Manoshi Ramanayake", AddressNo = "No 300/8", Street = "Kelum Uyana", City = "Doranagoda", JobRole = "Cloud Assistant" },
                new Author { Id = 3, FullName = "Nansara Piyumal", AddressNo = "No 255/4", Street = "Watareka", City = "Galle", JobRole = "Machanical Engineer" },
                new Author { Id = 4, FullName = "Nimal Premarathne", AddressNo = "No 27/2", Street = "udapita", City = "deldeniya", JobRole = "Teacher" });

            modelBuilder.Entity<Todo>().HasData(new Todo[] {
            new Todo{
                Id = 1,
                Title = "Get books for School - DB ",
                Description = "Get some text books for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
                AuthorId = 1
            },
            new Todo
            {
                Id = 2,
                Title = "Get vegetable",
                Description = "Get vegetable for week",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.New,
                AuthorId = 1
            },
            new Todo
            {
                Id = 3,
                Title = "Water the plants",
                Description = "Water all the plants quickly",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(1),
                Status = TodoStatus.New,
                AuthorId = 2
            },
            });

        }

    }
}
