using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ScrapBook.Common.Models;

namespace ScrapBook.API.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Idea> Ideas { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Relationship> Relationships { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=my_host;Database=my_db;Username=my_user;Password=my_pw");
    }
}
