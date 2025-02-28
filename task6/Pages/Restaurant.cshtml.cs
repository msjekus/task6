using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace task6.Pages
{
    public class RestaurantModel : PageModel
    {
        public string Name { get; set; } = "La Famiglia";
        public string Address { get; set; } = "������� ���.,�.��������,���.���������,12�";
        public string Cuisine { get; set; } = "���������";
        public string Description { get; set; } = "�������� ������� ���������";
        
        public void OnGet()
        {
        }
    }
}
