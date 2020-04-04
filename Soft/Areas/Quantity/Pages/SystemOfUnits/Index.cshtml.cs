using System.Threading.Tasks;
using Abc.Pages.Quantity;
using Abc.Domain.Quantity;

namespace Abc.Soft.Areas.Quantity.Pages.SystemOfUnits
{
    public class IndexModel : SystemsOfUnitsPage
    {
        public IndexModel(ISystemOfUnitsRepository r) : base(r) { }
        
        public async Task OnGetAsync(string sortOrder,
            string currentFilter, string searchString, int? pageIndex, string fixedValue, string fixedFilter)
        {
            await getList(sortOrder, currentFilter, searchString, pageIndex, fixedFilter, fixedValue);
        }
    }
}
