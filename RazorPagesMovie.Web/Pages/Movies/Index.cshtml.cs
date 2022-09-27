using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Web.Data;
using RazorPagesMovie.Web.Models;

namespace RazorPagesMovie.Web.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie.Web.Data.MovieContext _context;

        public IndexModel(RazorPagesMovie.Web.Data.MovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
