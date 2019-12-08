using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MicroService.Models;

namespace MicroService.Controllers.Surveys
{
    public class DeleteModel : PageModel
    {
        private readonly MicroService.Models.MicroServiceContext _context;

        public DeleteModel(MicroService.Models.MicroServiceContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SuveyModel = await _context.SuveyModel.FindAsync(id);

            if (SuveyModel != null)
            {
                _context.SuveyModel.Remove(SuveyModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
