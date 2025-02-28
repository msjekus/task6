using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace task6.Pages
{
    public class RestaurantModel : PageModel
    {
        public string Name { get; set; } = "La Famiglia";
        public string Address { get; set; } = "Одеська обл.,м.Подільськ,вул.Кузовкова,12а";
        public string Cuisine { get; set; } = "Італійська";
        public string Description { get; set; } = "Ресторан сімейних цінностей";
        
        public void OnGet()
        {
        }
    }
}
