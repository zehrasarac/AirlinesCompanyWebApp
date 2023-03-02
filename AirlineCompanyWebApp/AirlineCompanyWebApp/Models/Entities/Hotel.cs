using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace AirlineCompanyWebApp.Models.Entities
{
    [Table("Hotels")]
    public class Hotel:BaseEntity
    {
        public string HotelName { get; set; }
        public string HotelAddress { get; set; }
        public decimal HotelPricePerNight { get; set; }
        public string HotelImage { get; set; }
        public virtual ICollection<HotelRental> HotelRentals { get; set; }
    }
}
