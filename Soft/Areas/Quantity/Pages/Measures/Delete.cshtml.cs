using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abc.Pages.Quantity;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;

namespace Abc.Soft.Areas.Quantity.Pages.Measures
{
    public class DeleteModel : MeasuresPage
    {
        public DeleteModel(IMeasuresRepository r) : base(r) { }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            var o = await db.Get(id);
            Item = MeasureViewFactory.Create(o);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            await db.Delete(id);
            return RedirectToPage("./Index");
        }
    }
}
