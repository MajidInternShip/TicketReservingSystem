using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TicketReservingSystem.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Airline")]
        public int AirlineID { get; set; }
        [ForeignKey("Flight")]
        public int FligthId { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public int PaymentID { get; set; }
        public int OrderStauseId { get; set; }

    }
}
