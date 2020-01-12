using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketReservingSystem.Models
{
    public class Ticket
    {
        public int ID { get; set; }
        public int FlightID { get; set; }
        public int SeatNumber { get; set; }
        public int Price { get; set; }
        public int StateID { get; set; }
       
    }
}
