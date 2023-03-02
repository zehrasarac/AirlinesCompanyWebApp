using Castle.Components.DictionaryAdapter;
using System;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;


namespace AirlineCompanyWebApp.Models.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
