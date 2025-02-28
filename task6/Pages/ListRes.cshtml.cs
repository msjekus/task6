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
                new Restaurant {Name ="Oliva", Address="м.Київ,вул.В.Васильківська,34", 
                    Cuisine="Італійська", Description="Домашня атмосфера і лаконічне меню"},
                new Restaurant {Name ="Mons Pius", Address="м.Львів,вул. Л.Українки, 14", 
                    Cuisine="Локальна та європейська", Description="Атмосфера старого Львова"},
                new Restaurant {Name ="Компот", Address="м.Одеса,вул.Дерибасівська,20", 
                    Cuisine="Східноєвропейська домашня", Description="Можна придбати солодощі та свіжу випічку на винос"}
            };
        }
    }
}
