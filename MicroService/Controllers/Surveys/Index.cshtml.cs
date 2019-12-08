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
    public class IndexModel : PageModel
    {
        private readonly MicroService.Models.MicroServiceContext _context;

        public IndexModel(MicroService.Models.MicroServiceContext context)
        {
            _context = context;
        }

        public IList<SuveyModel> SuveyModel { get;set; }

        public async Task OnGetAsync()
        {
            SuveyModel = await _context.SuveyModel.ToListAsync();
        }
    }
}
