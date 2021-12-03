using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_MOVIES.Data;
using ASP_MOVIES.Models;

namespace ASP_MOVIES.Pages.Movie
{
    public class IndexModel : PageModel
    {
        private readonly ASP_MOVIES.Data.ApplicationDbContext _context;

        public IndexModel(ASP_MOVIES.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Movies> Movies { get;set; }

        public async Task OnGetAsync()
        {
            Movies = await _context.Movies.ToListAsync();
        }
    }
}
