using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab3.Data;
using Lab3.Models;

namespace Lab3.Pages_ProvincePages
{
    public class IndexModel : PageModel
    {
        private readonly Lab3.Data.ApplicationDbContext _context;

        public IndexModel(Lab3.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Province> Province { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Province = await _context.Provinces
                .Include(p => p.Cities)
                .ToListAsync();
        }
    }
}
