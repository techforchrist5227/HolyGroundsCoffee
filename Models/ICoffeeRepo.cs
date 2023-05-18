namespace HolyGroundsCoffee.Models
{
    public interface ICoffeeRepo
    {
        IEnumerable<Coffee> Coffees { get; }
        IEnumerable<Coffee> CoffeeOfTheWeek { get; }

        Coffee? GetCoffeeById(int coffeeId);
    }
}
