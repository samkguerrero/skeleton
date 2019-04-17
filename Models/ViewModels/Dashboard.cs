using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace LoginRegistration.Models
{
    public class Dashboard
    {
        public User UserLoggedIn {get;set;}
        public List<Wedding> Weddings {get;set;}

    }
}