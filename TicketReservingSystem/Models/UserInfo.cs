using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TicketReservingSystem.Models
{
    public class UserInfo
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("UserGroup")]
        public int UserGroupID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string gender { get; set; }
        public string PhoneNumber { get; set; }
    }
}
