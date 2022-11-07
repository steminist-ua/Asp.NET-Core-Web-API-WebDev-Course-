using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Context
{
    public class FilmsContext : DbContext
    {
        public FilmsContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Genre> Genres { get; set; }
    }
}
