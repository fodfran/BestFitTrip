﻿using System;
using System.Collections.Generic;

namespace BestFitTrip.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public IList<Trip> Trips { get; set; }

    }
}
