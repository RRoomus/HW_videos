using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abc.Pages.Quantity;
using Abc.Domain.Quantity;

namespace Abc.Soft.Areas.Quantity.Pages.Units
{
    public class EditModel : UnitsPage
    {
        public EditModel(IUnitsRepository r) : base(r) { }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            await getObject(id);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await updateObject();
            return RedirectToPage("./Index");
        }
    }
}
