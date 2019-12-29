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
        public SwaggerLabContext (DbContextOptions<SwaggerLabContext> options)
            : base(options)
        {
        }

        public DbSet<SwaggerLab.Model.User> User { get; set; }
    }
}
