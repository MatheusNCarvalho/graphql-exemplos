using AutoMapper;
using HotelReservation.API.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservation.API.Model
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(x =>
            {
                x.CreateMap<Guest, GuestModel>().ReverseMap();
                x.CreateMap<Room, RoomModel>().ReverseMap();
                x.CreateMap<Reservation, ReservationModel>().ReverseMap();
            });
        }
    }
}
