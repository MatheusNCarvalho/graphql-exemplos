using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservation.API.Model
{
    public class Guest
    {
        protected Guest() { }

        public Guest(string name, DateTime registerDate)
        {
            Name = name;
            RegisterDate = registerDate;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime RegisterDate { get; set; }
    }


    public enum RoomStatus
    {
        Unavailable = 1,
        Available = 2
    }


}
