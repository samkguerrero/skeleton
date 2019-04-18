using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace LoginRegistration.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}

        [Required]
        [MinLength(2)]
        [Display(Name="First Name")]
        public string Fname {get;set;}

        [Required]
        [MinLength(2)]
        [Display(Name="Last Name")]
        public string Lname {get;set;}

        [Required]
        [EmailAddress]
        [Display(Name="Email")]
        public string Email {get;set;}

        [Required]
        [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
        [DataType(DataType.Password)]
        [Display(Name="Password")]
        public string Password {get;set;}

        public List<Association> Things {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [Display(Name="Confirm Password")]
        public string ConfirmPassword {get;set;}



    }
}