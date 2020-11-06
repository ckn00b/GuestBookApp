using System;
using System.Collections.Generic;

namespace GuestBookApp.Data
{
    public class Guest
    {
        public string GuestName { get; set; }
        public string GuestMessage { get; set; }
        public DateTime GuestDateTime { get; set; }

        public static List<Guest> AddToGuestList(List<Guest> Guests, Guest newGuest)
        {
            Guests.Add(newGuest);
            return Guests;
        }
    }
}
