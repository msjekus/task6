using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace task6.Pages
{
    public class IndexModel : PageModel
    {
        public int Index { get; set; }
        public void OnGet()
        {
            Index = DateTime.UtcNow.DayOfYear;
        }
    }
}
