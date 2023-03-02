using Castle.Components.DictionaryAdapter;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace AirlineCompanyWebApp.Models.Entities
{
    [Table("Flights")]
    public class Flight
    {
        [Key]
        public int FlightId { get; set; }
        public int AirlineId { get; set; }
        public string FlightNumber { get; set; }
        public string DepatureAirport { get; set; }
        public string ArrivialAirport { get; set; }
        public DateTime DepatureDate { get; set; }
        public DateTime ArrivialDate { get; set; }
        public decimal Price { get; set; }
        [ForeignKey("AirlineId")]
        public virtual Airline Airline { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
