using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Applnsights.Demo.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your application description page.";
            throw new Exception("Collecting insights by codestellar");
        }
    }
}
