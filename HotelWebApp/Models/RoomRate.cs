using System;
using System.Collections.Generic;

#nullable disable

namespace HotelWebApp.Models
{
    public partial class RoomRate
    {
        public int Id { get; set; }
        public decimal? Cost { get; set; }
        public DateTime? Date { get; set; }

    }
}
