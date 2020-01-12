using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TicketReservingSystem.Models
{
    public class Payment
    {
        [Key]
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int AuthID { get; set; }
        public string Staus { get; set; }
        public string Amounth { get; set; }
        public string desc { get; set; }
    }
}
