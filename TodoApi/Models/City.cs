using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class City
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public ICollection<Person> People { get; set; }

    }
}