using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SuveyService.Models;

namespace SuveyService.Pages.Suveys
{
    public class CreateModel : PageModel
    {
        private readonly SuveyService.Models.SuveyServiceContext _context;

        public CreateModel(SuveyService.Models.SuveyServiceContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Suvey Suvey { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Suvey.Add(Suvey);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}