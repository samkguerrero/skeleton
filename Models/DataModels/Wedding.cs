using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace LoginRegistration.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId {get;set;}

        public int Creator {get;set;}

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

        public List<Guest> Users {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}