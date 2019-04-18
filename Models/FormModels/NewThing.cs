using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginRegistration.Models
{
    public class NewThing
    {

        [Required]
        [MinLength(2)]
        [Display(Name="Wedder One")]
        public string WedderOne {get;set;}

        [Required]
        [MinLength(2)]
        [Display(Name="Wedder Two")]
        public string WedderTwo {get;set;}

        [Required]
        [Display(Name="Date")]
        public DateTime Date {get;set;}

        [Required]
        [Display(Name="Wedding Address")]
        public string WeddingAddress {get;set;}

    }
}