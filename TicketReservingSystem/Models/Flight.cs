using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TicketReservingSystem.Models
{
    public class Flight
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Airline")]
        public int AirlineID { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public string StartDate { get; set; }
        public string Duration { get; set; }
        public int NumberOfSeat { get; set; }
        public  ICollection<Ticket> Tickets;
    }
}
