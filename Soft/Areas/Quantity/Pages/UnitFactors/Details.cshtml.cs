using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abc.Pages.Quantity;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;

namespace Abc.Soft.Areas.Quantity.Pages.UnitFactors
{
    public class DetailsModel : UnitFactorsPage
    {
        public DetailsModel(IUnitFactorRepository r) : base(r) { }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await getObject(id, fixedValue, fixedFilter);
            return Page();
        }
    }
}
