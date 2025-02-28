using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using task6.Models;


namespace task6.Pages
{
    public class ListModel : PageModel
    {
        public List<Country> Countries { get; set; } = new();
        public void OnGet()
        {
            Countries = new List<Country>
            {
                new Country { Name = "Ukraine", Capital = "Kyiv", Population = "41 million", Square = "603 700 "  },
                new Country { Name = "Japan", Capital = "Tokyo", Population = "126 million", Square = "377 974 " },
                new Country { Name = "Italy", Capital = "Rome", Population = "58 million", Square = "302 073 " },
                new Country { Name = "Brazil", Capital = "Brasilia", Population = "211 million", Square = "8 510 000 " }
            };
        }
    }
}
