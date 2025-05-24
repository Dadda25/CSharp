namespace TravelApi.Models
{
    public class Destination
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public decimal Rating { get; set; }
        public string Tag { get; set; }
    }
}