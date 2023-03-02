using System;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;


namespace AirlineCompanyWebApp.Models.Entities
{
    [Table("Bookings")]
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        public int Id { get; set; }
        public int FlightId { get; set; }
        public DateTime BookingDate { get; set; }
        public string BookingStatus { get; set; }
        [ForeignKey("Id")]
        public virtual Customer Customer { get; set; }
        [ForeignKey("FlightId")]
        public virtual Flight Flight { get; set; }

    }
}
