using System;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace AirlineCompanyWebApp.Models.Entities
{
    [Table("CarRentals")]
    public class CarRental:BaseEntity
    {
        public int CustomerId { get; set; }
        public int CarId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public decimal RentalPrice { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        [ForeignKey("CarId")]
        public virtual Car Car { get; set; }
    }
}
