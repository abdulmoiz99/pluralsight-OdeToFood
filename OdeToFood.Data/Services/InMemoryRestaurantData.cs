using OdeToFood.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Services
{
   public  class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {Id = 1, Name = "Scott's Pizza" ,Cuisine =CuisineType.Italian},
                new Restaurant {Id = 1, Name = "Tersiguels" ,Cuisine =CuisineType.French},
                new Restaurant {Id = 1, Name = "Mango Grove " ,Cuisine =CuisineType.Pakistani},
            };
        }

        public void Add(Restaurant restaurant)
        {
            restaurants.Add(restaurant);
            restaurant.Id = restaurants.Max(r => r.Id) + 1;
        }

        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }

        public void Update(Restaurant restaurant)
        {
            var existing = Get(restaurant.Id);
            if (existing!=null)
            {
                existing.Name = restaurant.Name;
                existing.Cuisine = restaurant.Cuisine; 
            }
        }
    }
}
