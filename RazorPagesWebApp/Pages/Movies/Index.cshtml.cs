using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesWebApp.Data;
using RazorPagesWebApp.Models;

namespace RazorPagesWebApp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesWebApp.Data.RazorPagesWebAppContext _context;

        public IndexModel(RazorPagesWebApp.Data.RazorPagesWebAppContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
