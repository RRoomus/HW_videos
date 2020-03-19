using System.Threading.Tasks;
using Abc.Pages.Quantity;
using Abc.Domain.Quantity;

namespace Abc.Soft.Areas.Quantity.Pages.Units
{
    public class IndexModel : UnitsPage
    {
        public IndexModel(IUnitsRepository r, IMeasuresRepository m) : base(r, m) { }
        
        public async Task OnGetAsync(string sortOrder,
            string currentFilter, string searchString, int? pageIndex, string fixedValue, string fixedFilter)
        {
            await getList(sortOrder, currentFilter, searchString, pageIndex, fixedValue, fixedFilter);
        }
    }
}
