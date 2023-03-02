using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace AirlineCompanyWebApp.Models.Entities
{
    [Table("Cars")]
    public class Car:BaseEntity
    {
        [MaxLength(10)]
        public string CarPlate { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public decimal CarPricePerDay { get; set; }
        public virtual ICollection<CarRental> CarRentals { get; set; }
    }
}
