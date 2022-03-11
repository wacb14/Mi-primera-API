using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models
{
    public class Person
    {
        [Key]
        public long Id { get; set; }
        public string DNI { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public long UserFK { get; set; }

        [ForeignKey("UserFK")]
        public User User { get; set; }
        public long CityFK { get; set; }

        [ForeignKey("CityFK")]
        public City City { get; set; }
    }
}
