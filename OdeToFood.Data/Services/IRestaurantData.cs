﻿using OdeToFood.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();

        public class InMemoryRestaurantData : IRestaurantData
        {
            public IEnumerable<Restaurant> GetAll()
            {
                throw new NotImplementedException();
            }
        }
    }
}
