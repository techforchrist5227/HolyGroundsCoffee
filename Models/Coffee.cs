namespace HolyGroundsCoffee.Models
{
    public class Coffee
    {
        public int CoffeeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public decimal PriceSmall { get; set; }
        public decimal PriceMedium { get; set; }
        public decimal PriceLarge { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageThumbnailUrl { get; set; }
        public bool IsCoffeeOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoryId  { get; set; }
        public Category Category { get; set; } = default!;
    }
}
