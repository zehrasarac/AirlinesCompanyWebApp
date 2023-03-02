
using Microsoft.EntityFrameworkCore;
using Castle.Components.DictionaryAdapter;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.Collections.Generic;

namespace AirlineCompanyWebApp.Models.Entities
{
    [Table("Books")]
    public class Customer: BaseEntity
    {

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Address { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<CarRental> CarRentals { get; set; }  
        public virtual ICollection<HotelRental> HotelRentals { get; set; }
        

    }
}
