namespace HolyGroundsCoffee.Models
{
    public class CoffeeCategory
    {
        public int CategoryId { get; set; }

        public string? CategoryName { get; set; } = string.Empty;

        public string? Description { get; set; }

        public List<Coffee>? Coffees { get; set; }
    }
}
