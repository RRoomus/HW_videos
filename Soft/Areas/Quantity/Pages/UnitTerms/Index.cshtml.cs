using System.Threading.Tasks;
using Abc.Pages.Quantity;
using Abc.Domain.Quantity;

namespace Abc.Soft.Areas.Quantity.Pages.UnitTerms
{
    public class IndexModel : UnitTermsPage
    {
        public IndexModel(IUnitTermsRepository r) : base(r) { }
        
        public async Task OnGetAsync(string sortOrder,
            string currentFilter, string searchString, int? pageIndex, string fixedValue, string fixedFilter)
        {
            await getList(sortOrder, currentFilter, searchString, pageIndex, fixedFilter, fixedValue);
        }
    }
}
