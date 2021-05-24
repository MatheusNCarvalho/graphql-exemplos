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

    public class Room
    {
        public Room(int number, string name, RoomStatus status, bool allowedSmoking)
        {
            Number = number;
            Name = name;
            Status = status;
            AllowedSmoking = allowedSmoking;
        }

        protected Room() { }


        public long Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public RoomStatus Status { get; set; }
        public bool AllowedSmoking { get; set; }

    }

    public class Reservation
    {
        protected Reservation() { }

        public Reservation(DateTime checkinDate, DateTime checkoutDate, long roomId, long guestId)
        {
            CheckinDate = checkinDate;
            CheckoutDate = checkoutDate;
            RoomId = roomId;
            GuestId = guestId;
        }

        public long Id { get; set; }

        public Room Room { get; set; }
        public long RoomId { get; set; }


        public Guest Guest { get; set; }
        public long GuestId { get; set; }

        public DateTime CheckinDate { get; set; }

        public DateTime CheckoutDate { get; set; }


    }


}
