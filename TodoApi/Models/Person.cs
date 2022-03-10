namespace TodoApi.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string DNI { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
    }
}
