﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly ASP_MOVIES.Data.ApplicationDbContext _context;

        public DetailsModel(ASP_MOVIES.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Movies Movies { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movies = await _context.Movies.FirstOrDefaultAsync(m => m.ID == id);

            if (Movies == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
