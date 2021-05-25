using GraphQL.Types;
using HotelReservation.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservation.API.GraphQL
{
    public class GuestType : ObjectGraphType<Guest>
    {
        public GuestType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.RegisterDate);
        }
    }

    public class ReservationType : ObjectGraphType<Reservation>
    {

        public ReservationType()
        {
            Field(x => x.Id);
            Field(x => x.CheckinDate);
            Field(x => x.CheckoutDate);
            Field<GuestType>(nameof(Reservation.Guest));
            Field<RoomType>(nameof(Reservation.Room));
        }
    }

    public class RoomStatusType : EnumerationGraphType<RoomStatus>
    {

    }

    public class RoomType : ObjectGraphType<Room>
    {
        public RoomType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Number);
            Field(x => x.AllowedSmoking);
            Field<RoomStatusType>(nameof(Room.Status));
        }
    }
}
