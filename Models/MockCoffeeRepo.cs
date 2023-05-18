namespace HolyGroundsCoffee.Models
{
    public class MockCoffeeRepo : ICoffeeRepo

    {
        public IEnumerable<Coffee> Coffees => new List<Coffee>
        {

        }
    }
}
