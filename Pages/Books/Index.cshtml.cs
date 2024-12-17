using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BledeaIuliana_Lab2.Data;
using BledeaIuliana_Lab2.Models;

namespace BledeaIuliana_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly BledeaIuliana_Lab2.Data.BledeaIuliana_Lab2Context _context;

        public IndexModel(BledeaIuliana_Lab2.Data.BledeaIuliana_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
