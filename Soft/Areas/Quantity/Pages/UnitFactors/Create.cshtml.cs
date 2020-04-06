using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abc.Domain.Quantity;
using Abc.Pages.Quantity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Abc.Data.Quantity;

namespace Abc.Soft.Areas.Quantity.Pages.UnitFactors
{
    public class CreateModel : UnitFactorsPage
    {
        public CreateModel(IUnitFactorRepository r, IUnitsRepository u, ISystemOfUnitsRepository s) : base(r)
        {
            PageTitle = "Unit Factors";
            Units = createSelectList<Unit, UnitData>(u);
            SystemsOfUnits = createSelectList<SystemOfUnits, SystemsOfUnitsData>(s);
        }

        public IEnumerable<SelectListItem> Units { get; }
        public IEnumerable<SelectListItem> SystemsOfUnits { get; }


        public IActionResult OnGet(string fixedFilter, string fixedValue)
        {
            FixedFilter = fixedFilter;
            FixedValue = fixedValue;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            if (!await addObject(fixedFilter, fixedValue)) return Page();
            return Redirect(IndexUrl);
        }
    }
}
