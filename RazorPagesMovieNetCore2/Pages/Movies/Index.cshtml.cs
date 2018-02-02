using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovieNetCore2.Models;

namespace RazorPagesMovieNetCore2.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovieNetCore2.Models.MovieContext _context;

        public IndexModel(RazorPagesMovieNetCore2.Models.MovieContext context)
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
