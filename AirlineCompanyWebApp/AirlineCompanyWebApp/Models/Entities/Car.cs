﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace AirlineCompanyWebApp.Models.Entities
{
    [Table("Cars")]
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public decimal CarPricePerDay { get; set; }
        public string CarImage { get; set; }
        public virtual ICollection<CarRental> CarRentals { get; set; }
    }
}