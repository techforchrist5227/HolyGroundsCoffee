namespace HolyGroundsCoffee.Models
{
    public class MockCategoryRepo : ICategoryRepository

    {
        public IEnumerable<CoffeeCategory> AllCategories => new List<CoffeeCategory>
        {
            new CoffeeCategory {CategoryId=1,CategoryName="HeBrews It", Description="Hot coffee brewed as He would have it"},
            new CoffeeCategory {CategoryId=2,CategoryName="Rise!", Description="Espresso coffee drinks."},
            new CoffeeCategory {CategoryId=3,CategoryName="Baptismal", Description="Our Hebrews It coffe, but ICED!"},
            new CoffeeCategory {CategoryId=4,CategoryName="Cold Brrrews", Description="Cold brews so cold the name is shivering"},
            new CoffeeCategory {CategoryId=5,CategoryName="Lattes", Description="Signature lattes made with milk as white as snow."},
            new CoffeeCategory {CategoryId=6,CategoryName="316 Signatures", Description="Specialty coffee drinks hot or iced."}
        };
    }
}
