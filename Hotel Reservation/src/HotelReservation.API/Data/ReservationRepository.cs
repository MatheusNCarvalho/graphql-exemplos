using AutoMapper.QueryableExtensions;
using HotelReservation.API.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservation.API.Data
{
    public class ReservationRepository
    {
        private readonly MyHotelDbContext _context;

        public ReservationRepository(MyHotelDbContext context)
        {
            _context = context;
        }

        public async Task<List<T>> GetAll<T>()
        {
            return await _context.Set<Reservation>()                
                .Include(x => x.Room)
                .Include(x => x.Guest)                      
                .ProjectTo<T>(AutoMapperConfig.RegisterMappings())
                .ToListAsync();
        }
    }
}
