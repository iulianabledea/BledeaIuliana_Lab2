using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BledeaIuliana_Lab2.Models;

namespace BledeaIuliana_Lab2.Data
{
    public class BledeaIuliana_Lab2Context : DbContext
    {
        public BledeaIuliana_Lab2Context (DbContextOptions<BledeaIuliana_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<BledeaIuliana_Lab2.Models.Book> Book { get; set; } = default!;
    }
}
