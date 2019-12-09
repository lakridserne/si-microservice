using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SuveyService.Models;

namespace SuveyService.Pages.Suveys
{
    public class IndexModel : PageModel
    {
        private readonly SuveyService.Models.SuveyServiceContext _context;

        public IndexModel(SuveyService.Models.SuveyServiceContext context)
        {
            _context = context;
        }

        public IList<Suvey> Suvey { get;set; }

        public async Task OnGetAsync()
        {
            Suvey = await _context.Suvey.ToListAsync();
        }
    }
}
