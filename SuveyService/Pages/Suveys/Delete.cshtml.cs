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
    public class DeleteModel : PageModel
    {
        private readonly SuveyService.Models.SuveyServiceContext _context;

        public DeleteModel(SuveyService.Models.SuveyServiceContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Suvey Suvey { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Suvey = await _context.Suvey.FirstOrDefaultAsync(m => m.ID == id);

            if (Suvey == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Suvey = await _context.Suvey.FindAsync(id);

            if (Suvey != null)
            {
                _context.Suvey.Remove(Suvey);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
