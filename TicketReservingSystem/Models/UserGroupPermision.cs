using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TicketReservingSystem.Models
{
    public class UserGroupPermision
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("UserGroup")]
        public int UserGroupID { get; set; }
        public int PermissionID { get; set; }
    }
}
