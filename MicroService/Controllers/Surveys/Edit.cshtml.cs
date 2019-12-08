using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MicroService.Models;

namespace MicroService.Controllers.Surveys
{
    public class EditModel : PageModel
    {
        private readonly MicroService.Models.MicroServiceContext _context;

        public EditModel(MicroService.Models.MicroServiceContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SuveyModel SuveyModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SuveyModel = await _context.SuveyModel.FirstOrDefaultAsync(m => m.ID == id);

            if (SuveyModel == null)
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

            _context.Attach(SuveyModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuveyModelExists(SuveyModel.ID))
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

        private bool SuveyModelExists(int id)
        {
            return _context.SuveyModel.Any(e => e.ID == id);
        }
    }
}
