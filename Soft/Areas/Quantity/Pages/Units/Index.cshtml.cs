using System.Threading.Tasks;
using Abc.Pages.Quantity;
using Abc.Domain.Quantity;

namespace Abc.Soft.Areas.Quantity.Pages.Units
{
    public class IndexModel : UnitsPage
    {
        public IndexModel(IUnitsRepository r) : base(r) { }
        
        public async Task OnGetAsync(string sortOrder,
            string currentFilter, string searchString, int? pageIndex)
        {
            await getList(sortOrder, currentFilter, searchString, pageIndex);
        }
    }
}
