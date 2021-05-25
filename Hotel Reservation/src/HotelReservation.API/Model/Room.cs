namespace HotelReservation.API.Model
{
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


}
