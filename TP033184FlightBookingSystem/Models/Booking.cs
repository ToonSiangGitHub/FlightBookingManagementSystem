//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TP033184FlightBookingSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Booking
    {
        public int bookingID { get; set; }
        public Nullable<int> flightID { get; set; }
        public Nullable<int> passengerID { get; set; }
        public Nullable<int> seat { get; set; }
    
        public virtual Flight Flight { get; set; }
        public virtual Passenger Passenger { get; set; }
    }
}