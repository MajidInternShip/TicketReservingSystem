﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketReservingSystem.Models
{
    public class TicketStatus
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }

    }
}
