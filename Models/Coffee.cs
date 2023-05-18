namespace HolyGroundsCoffee.Models
{
    public class Coffee
    {
        public int CoffeeId { get; set; }
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public string? CoffeeOfTheWeek { get; set; }

        public decimal Price { get; set; }

        public string? ImageUrl { get; set; }

        public string? ImageThumbnailUrl { get; set; }

        public bool InStock { get; set; }

        public int CategoryId { get; set; }

        public CoffeeCategory CoffeeCategory { get; set; } = default!;
    }
}
