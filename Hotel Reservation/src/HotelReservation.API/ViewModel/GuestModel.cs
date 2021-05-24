using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservation.API.ViewModel
{
    public class GuestModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime RegisterDate { get; set; }
    }


    public class RoomModel
    {
        public long Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public short Status { get; set; }
        public bool AllowedSmoking { get; set; }

    }

    public class ReservationModel
    {

        public long Id { get; set; }

        public RoomModel Room { get; set; }
        public GuestModel Guest { get; set; }
        public DateTime CheckinDate { get; set; }
        public DateTime CheckoutDate { get; set; }


    }


}
