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
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<MeasureView> MeasureView { get;set; }

        public async Task OnGetAsync()
        {
            MeasureView = await _context.MeasureView.ToListAsync();
        }
    }
}
