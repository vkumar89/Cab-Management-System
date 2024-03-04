using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CabManagment.Models
{
    public class Booking_Requests
    {
        public int bookingid { get; set; }
        public string startpoint {  get; set; }
        public string endpoint { get; set; }
        public string vehical { get; set; }

    }
}