using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstRazerPagesUI.Pages
{
    public class AboutModel : PageModel
    {
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            return RedirectToPage("/FilmPhotos");
        }
    }
}