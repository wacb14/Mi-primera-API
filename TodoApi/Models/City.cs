using System.Collections.Generic;

namespace TodoApi.Models
{
    public class City{
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Person> People { get; set; }

    }
}