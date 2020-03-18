using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abc.Pages.Quantity;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;

namespace Abc.Soft.Areas.Quantity.Pages.Units
{
    public class DetailsModel : UnitsPage
    {
        public DetailsModel(IUnitsRepository r) : base(r) { }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            await getObject(id);
            return Page();
        }
    }
}
