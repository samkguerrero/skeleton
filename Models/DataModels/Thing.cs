using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace LoginRegistration.Models
{
    
    public class OldEnoughAttribute : ValidationAttribute 
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext) 
        {
            if((DateTime)value >= DateTime.Today.AddYears(-18)) 
            {
                return new ValidationResult("The chef must be at least 18 years old.");
            }
            else 
            {
                return ValidationResult.Success;
            }
        }
    }

    public class Thing
    {
        [Key]
        public int ThingId {get;set;}

        public int Creator {get;set;}

        [Required]
        [MinLength(2)]
        [Display(Name="Name")]
        public string Name {get;set;}

        [Required]
        [OldEnough]
        [Display(Name="Date")]
        public DateTime Date {get;set;}

        public List<Association> Users {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}