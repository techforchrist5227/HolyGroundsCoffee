namespace HolyGroundsCoffee.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<CoffeeCategory> AllCategories { get; }
    }
}
