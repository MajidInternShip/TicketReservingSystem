﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketReservingSystem.Models
{
    public class Airline
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public ICollection<Flight> Flights;
            

    }
}
