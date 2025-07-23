using RapidApiConsume.Models;
using System.Collections.Generic;

namespace RapiApiConsume.Models
{
    public class BookingApiLocationSearchRoot
    {
        public bool status { get; set; }
        public string message { get; set; }
        public long timestamp { get; set; }
        public List<BookingApiLocationSearchViewModel> data { get; set; }
    }
}
