using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SwaggerLab.Model;

namespace SwaggerLab.Data
{
    public class SwaggerLabContext : DbContext
    {
        public SwaggerLabContext(DbContextOptions<SwaggerLabContext> options)
            : base(options)
        {
        }

        public DbSet<SwaggerLab.Model.User> User { get; set; }
        public DbSet<SwaggerLab.Model.Todo> Todo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new SwaggerLab.Model.User
            {
                ID = Guid.Parse("14d4f7fa-0b9b-4378-b0e5-fdcce6fd3a32"),
                Name = "felaray",
                Mobile = "+886912345678",
                Password = ""
            });

        }
    }
}
