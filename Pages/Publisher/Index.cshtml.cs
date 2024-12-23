﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BledeaIuliana_Lab2.Data;
using BledeaIuliana_Lab2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BledeaIuliana_Lab2.Pages.Publisher
{
    public class IndexModel : PageModel
    {
        private readonly BledeaIuliana_Lab2.Data.BledeaIuliana_Lab2Context _context;

        public IndexModel(BledeaIuliana_Lab2.Data.BledeaIuliana_Lab2Context context)
        {
            _context = context;
        }

        public IList<BledeaIuliana_Lab2.Models.Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher
                .Include(p => p.Books) // pt a include relatia cu books
                .ToListAsync();
        }

    }
}
