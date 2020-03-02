using System.Collections.Generic;
using System.Threading.Tasks;
using Abc.Facade;
using Abc.Pages.Quantity;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;

namespace Abc.Soft.Areas.Quantity.Pages.Measures
{
    public class IndexModel : MeasuresPage
    {
        public string SearchString;

        public IndexModel(IMeasuresRepository r) : base(r) { }

        public string NameSort { get; set; }
        public string DateSort { get; set; }

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            NameSort = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";
            db.SortOrder = sortOrder;
            SearchString = searchString;
            db.SearchString = searchString;
            var l = await db.Get();
            Items = new List<MeasureView>();
            foreach (var e in l)
            {
                Items.Add(MeasureViewFactory.Create(e));
            }
        }
    }
}
