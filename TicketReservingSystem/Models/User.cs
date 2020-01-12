using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketReservingSystem.Models
{
    public class User:PublicObject
    {
        [Key]
        public int UserId {get;set;}
        public string Username{get;set;}
        public string Password{get;set;}
        public int Mobile{get;set;}
        public string Email{get;set;}
        [ForeignKey("UserGroup")]
        public int UserGroupID {get;set;}


    }
}
