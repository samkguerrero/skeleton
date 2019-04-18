using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace LoginRegistration.Models
{
    public class Association
    {
        [Key]
        public int AssociationId {get;set;}
        public int UserId {get;set;}
        public int ThingId {get;set;}
        public User User {get;set;}
        public Thing Thing {get;set;}
    }
}