using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PS3_NET.Pages.Models;
using System;

namespace PS3_NET.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

      
        public Person person { get; set; }
        public void OnGet()
        {
          
        }

        public IActionResult OnPost(Person person)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Request.Form["choice"] == "0")
            {
                person.height = person.height / 100;
                
            }
            
            return RedirectToPage("Test",person); 
           
        }


    }
}