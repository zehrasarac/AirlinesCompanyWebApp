using Castle.Components.DictionaryAdapter;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace AirlineCompanyWebApp.Models.Entities
{
    [Table("Airlines")]
    public class Airline:BaseEntity
    {
        public string AirlineName { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }

    }
}
