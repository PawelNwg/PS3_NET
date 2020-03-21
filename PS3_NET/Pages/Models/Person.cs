using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;




namespace PS3_NET.Pages.Models
{
    public class Person
    {
        [Display(Name = "Imię")]
        [Required(ErrorMessage = "Imię jest obowiązkowe")]
        [RegularExpression(@"[A-Z]*[a-z]*",
        ErrorMessage = "Imię składa się tylko z liter")]
        [MaxLength(15)]
        public string firstName { get; set; }

        [Display(Name = "E-mail")]     
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Wiek")]
        [Range (1,120)]

        public int age { get; set; }

        [Display(Name = "Płeć")]     
        public string sex { get; set; }

        [Display(Name = "Waga")]
        [Required(ErrorMessage = "Waga jest obowiązkowa")]
        
        public double weight { get; set; }

        [Display(Name = "Wzrost")]
        [Required(ErrorMessage = "Wzrost jest obowiązkowy")]
        public double height { get; set; }

       
    }
}
