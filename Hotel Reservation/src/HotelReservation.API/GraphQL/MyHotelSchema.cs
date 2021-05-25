using GraphQL.Types;
using GraphQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservation.API.GraphQL
{
    public class MyHotelSchema : Schema
    {
        public MyHotelSchema(IServiceProvider resolver) : base(resolver)
        {
          Query = resolver.
        }
    }
}
