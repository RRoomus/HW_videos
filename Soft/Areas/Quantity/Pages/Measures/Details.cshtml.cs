using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Abc.Facade;
using Soft.Data;

namespace Abc.Soft.Areas.Quantity.Pages.Measures
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public MeasureView MeasureView { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MeasureView = await _context.MeasureView.FirstOrDefaultAsync(m => m.Id == id);

            if (MeasureView == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
