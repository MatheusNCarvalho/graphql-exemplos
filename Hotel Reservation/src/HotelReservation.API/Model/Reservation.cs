using System;

namespace HotelReservation.API.Model
{
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
