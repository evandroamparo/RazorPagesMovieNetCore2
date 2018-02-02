using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesMovieNetCore2.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your contact page.";
        }
    }
}
