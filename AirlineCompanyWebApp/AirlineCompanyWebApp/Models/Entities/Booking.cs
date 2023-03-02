using System;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;


namespace AirlineCompanyWebApp.Models.Entities
{
    [Table("Bookings")]
    public class Booking:BaseEntity
    {
        public int CustomerId { get; set; }
        public int FlightId { get; set; }
        public DateTime BookingDate { get; set; }
        public string BookingStatus { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        [ForeignKey("FlightId")]
        public virtual Flight Flight { get; set; }

    }
}
