namespace HolyGroundsCoffee.Models
{
    public interface ICoffeeCategoryRepo
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
