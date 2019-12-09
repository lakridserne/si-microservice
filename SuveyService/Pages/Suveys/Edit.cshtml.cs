using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SuveyService.Models;

namespace SuveyService.Pages.Suveys
{
    public class EditModel : PageModel
    {
        private readonly SuveyService.Models.SuveyServiceContext _context;

        public EditModel(SuveyService.Models.SuveyServiceContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Suvey).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuveyExists(Suvey.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SuveyExists(int id)
        {
            return _context.Suvey.Any(e => e.ID == id);
        }
    }
}
