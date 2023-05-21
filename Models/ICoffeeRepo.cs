namespace HolyGroundsCoffee.Models
{
    public interface ICoffeeRepo
    {
        //This is an enumerable that will list all the coffee details from the coffee class
        IEnumerable<Coffee> Coffees { get; }
        // Grabs the coffee of the week that will be generated
        IEnumerable<Coffee> CoffeesOfTheWeek { get; }
        // Grabs the pie type by ID and generates that
        Coffee? GetCoffeeById(int coffeeId);
    }
}
