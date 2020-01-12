using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TicketReservingSystem.Models
{
    public class OrderDetails
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Order")]
        public int OrderID { get; set; }
        [ForeignKey("Ticket")]
        public int TicketID { get; set; }
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int Price { get; set; }

    }
}
