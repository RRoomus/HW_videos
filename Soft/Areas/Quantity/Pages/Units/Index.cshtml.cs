using System.Threading.Tasks;
using Abc.Pages.Quantity;
using Abc.Domain.Quantity;

namespace Abc.Soft.Areas.Quantity.Pages.Units
{
    public class IndexModel : UnitsPage
    {
        public IndexModel(IUnitsRepository r, IMeasuresRepository m, IUnitFactorRepository f, IUnitTermsRepository t) : base(r, m, f, t) { }
        
        public async Task OnGetAsync(string sortOrder, string id,
            string currentFilter, string searchString, int? pageIndex, string fixedValue, string fixedFilter)
        {
            SelectedId = id;
            await getList(sortOrder, currentFilter, searchString, pageIndex, fixedValue, fixedFilter);
        }
    }
}
