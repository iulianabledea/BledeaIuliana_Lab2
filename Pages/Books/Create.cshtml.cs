using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BledeaIuliana_Lab2.Data;
using BledeaIuliana_Lab2.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BledeaIuliana_Lab2.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly BledeaIuliana_Lab2Context _context;

        public CreateModel(BledeaIuliana_Lab2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Book Book { get; set; } = default!;

        // Property to hold the list of publishers
        public SelectList PublisherList { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            // Fetch publishers from the database
            var publishers = await _context.Publisher.ToListAsync();

            // Populate the SelectList
            PublisherList = new SelectList(publishers, "Id", "PublisherName");

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                // Re-populate dropdown in case of validation failure
                var publishers = await _context.Publisher.ToListAsync();
                PublisherList = new SelectList(publishers, "Id", "PublisherName");
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

