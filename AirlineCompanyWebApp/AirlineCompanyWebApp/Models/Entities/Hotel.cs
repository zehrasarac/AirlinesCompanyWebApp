using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace AirlineCompanyWebApp.Models.Entities
{
    [Table("Hotels")]
    public class Hotel
    {
        [Key]
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public string HotelAddress { get; set; }
        public string HotelImage { get; set; }

    }
}
