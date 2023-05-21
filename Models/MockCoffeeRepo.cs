using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HolyGroundsCoffee.Models
{
    public class MockCoffeeRepo:ICoffeeRepo
    {
        private readonly ICoffeeRepo _coffeeRepo = new MockCoffeeRepo();

        public IEnumerable<Coffee> Coffees =>
            new List<Coffee>
            {
                new Coffee{CoffeeId=1, Name="He-Brews It", ShortDescription="Hot Brewed Pot Coffee", LongDescription="Our specialty BLESSED blend brewed from the pot.", PriceSmall=1.79M,PriceMedium=3.34M, PriceLarge=4.50M,ImageUrl="https://images.unsplash.com/photo-1554600740-951beab4712b?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=687&q=80",ImageThumbnailUrl="https://images.unsplash.com/photo-1598908314732-07113901949e?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1170&q=80", IsCoffeeOfTheWeek=false, InStock=true,
            },
             new Coffee{CoffeeId=2, Name="Rise!", ShortDescription="Espresso", LongDescription="Our specialty BLESSED espresso.", PriceSmall=1.79M,PriceMedium=3.34M, PriceLarge=4.50M,ImageUrl="https://images.unsplash.com/photo-1554600740-951beab4712b?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=687&q=80",ImageThumbnailUrl="https://images.unsplash.com/photo-1598908314732-07113901949e?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1170&q=80", IsCoffeeOfTheWeek=false, InStock=true,
            } };
        public IEnumerable<Coffee> CoffeesOfTheWeek { get; }

        public Coffee GetCoffeeById(int coffeeId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Coffee> SearchPies(string searchQuery)
        {
            throw new NotImplementedException();
        }

        public void CreateCoffee(Coffee coffee)
        {
            throw new System.NotImplementedException(); 
        }

        public void UpdateCoffee(Coffee coffee)
        {
            throw new System.NotImplementedException();
        }
    }

    
}
