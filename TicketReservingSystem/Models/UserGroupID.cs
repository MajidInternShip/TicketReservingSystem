using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketReservingSystem.Models
{
    public class UserGroupID
    {
        [Key]
        public int ID;
        public string title;
    }
}
