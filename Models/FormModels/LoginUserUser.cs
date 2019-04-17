using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginRegistration.Models
{
    public class LoginUserUser
    {
        public User User {get;set;}
        public LoginUser LoginUser {get;set;}

    }
}