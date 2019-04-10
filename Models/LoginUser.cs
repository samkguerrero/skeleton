using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginRegistration.Models
{
    public class LoginUser
    {

        [Required]
        [EmailAddress]
        [Display(Name="Email")]
        public string Email {get;set;}

        [Required]
        [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
        [DataType(DataType.Password)]
        [Display(Name="Password")]
        public string Password {get;set;}

    }
}