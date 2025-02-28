using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using task6.Models;

namespace task6.Pages
{
    public class ListResModel : PageModel
    {
        public List<Restaurant> Restaurants { get; set; } = new();
        public void OnGet()
        {
            Restaurants = new List<Restaurant>
            {
                new Restaurant {Name ="Oliva", Address="�.���,���.�.������������,34", 
                    Cuisine="���������", Description="������� ��������� � �������� ����"},
                new Restaurant {Name ="Mons Pius", Address="�.����,���. �.�������, 14", 
                    Cuisine="�������� �� �����������", Description="��������� ������� ������"},
                new Restaurant {Name ="������", Address="�.�����,���.������������,20", 
                    Cuisine="���������������� �������", Description="����� �������� �������� �� ���� ������ �� �����"}
            };
        }
    }
}
