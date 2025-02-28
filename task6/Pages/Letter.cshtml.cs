using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace task6.Pages
{
    public class LetterModel : PageModel
    {
        public char Letter { get; set; }
        public void OnGet()
        {
            Random random = new Random();
            Letter = (char)('A'+ random.Next(26));
        }
    }
}
