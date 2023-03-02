using System;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace AirlineCompanyWebApp.Models.Entities
{
    [Table("HotelRentals")]
    public class HotelRental
    {
        [Key]
        public int HotelRentalId { get; set; }
        public int Id { get; set; }
        public int HotelId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set;}
        public decimal RentalPrice { get; set; }
        [ForeignKey("Id")]
        public virtual Customer Customer { get; set; }
        [ForeignKey("HotelId")]
        public virtual Hotel Hotel { get; set; }

    }
}
