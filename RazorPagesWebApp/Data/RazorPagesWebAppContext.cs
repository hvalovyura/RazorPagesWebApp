using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesWebApp.Models;

namespace RazorPagesWebApp.Data
{
    public class RazorPagesWebAppContext : DbContext
    {
        public RazorPagesWebAppContext (DbContextOptions<RazorPagesWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesWebApp.Models.Movie> Movie { get; set; }
    }
}
