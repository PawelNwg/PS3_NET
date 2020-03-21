using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace PS3_NET.Pages
{
    public class TestModel : PageModel
    {

        [BindProperty(SupportsGet = true)]
        public string firstName { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Email { get; set; }

        [BindProperty(SupportsGet = true)]
        public string age { get; set; }

        [BindProperty(SupportsGet = true)]
        public string sex { get; set; }

        [BindProperty(SupportsGet = true)]
        public float weight { get; set; }

        [BindProperty(SupportsGet = true)]
        public float height { get; set; }

        public double BMI { get; set; }
        public void OnGet()
        {
            BMI = weight / (height * height);
            BMI = Math.Round(BMI, 2);
        }
    }
}

