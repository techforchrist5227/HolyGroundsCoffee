namespace HolyGroundsCoffee.Models
{
    // A mock repo for categories that mimics a DB without having an actual DB configured
    public class MockCategoryRepo : ICoffeeCategoryRepo
    // implement the coffee category repo
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>

            {
                new Category{CategoryId=1, CategoryName="On Fire!", Description="Hot coffee and espresso drinks that's on fire like our commitment to his Holiness."},
                new Category{CategoryId=2, CategoryName="Iced", Description="HolyGrounds coffee, but ICED!"},
                new Category{CategoryId=3, CategoryName="316 Signature", Description="We love our customers so much that we gave them these signature drinks, see what we did there?"},
                new Category{CategoryId=4, CategoryName="Brew at home", Description="Go throughout the world...or at least to your home and brew it yourself."},

            };
    }
}
