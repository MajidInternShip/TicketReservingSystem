using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketReservingSystem.Models
{
    public class Permession
    {
        [Key]
        public int ID { get; set; }
        public string URL { get; set; }
        public string name { get; set; }
        public string Desc { get; set; }
    }
}
