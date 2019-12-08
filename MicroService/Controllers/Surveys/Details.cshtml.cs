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
    public class DetailsModel : PageModel
    {
        private readonly MicroService.Models.MicroServiceContext _context;

        public DetailsModel(MicroService.Models.MicroServiceContext context)
        {
            _context = context;
        }

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
    }
}
