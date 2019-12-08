using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MicroService.Models;

namespace MicroService.Controllers.Surveys
{
    public class CreateModel : PageModel
    {
        private readonly MicroService.Models.MicroServiceContext _context;

        public CreateModel(MicroService.Models.MicroServiceContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public SuveyModel SuveyModel { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.SuveyModel.Add(SuveyModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}