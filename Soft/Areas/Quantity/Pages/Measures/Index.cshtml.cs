using System.Threading.Tasks;
using Abc.Pages.Quantity;
using Abc.Domain.Quantity;

namespace Abc.Soft.Areas.Quantity.Pages.Measures
{
    public class IndexModel : MeasuresPage
    {
        public IndexModel(IMeasuresRepository r, IMeasureTermsRepository t) : base(r, t) { }
        
        public async Task OnGetAsync(string sortOrder, string id,
            string currentFilter, string searchString, int? pageIndex, string fixedValue, string fixedFilter)
        {
            SelectedId = id;
            await getList(sortOrder, currentFilter, searchString, pageIndex, fixedFilter, fixedValue);
        }
    }
}
