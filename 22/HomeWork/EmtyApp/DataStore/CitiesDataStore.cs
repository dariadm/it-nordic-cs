using EmtyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmtyApp.DataStore
{
    public class CitiesDataStore
    {
        private static CitiesDataStore _store;

        public List<CityGetModel> Cities{get;private set;}

        public static CitiesDataStore GetInstance()
        {
            if (_store == null)
                _store = new CitiesDataStore();

            return _store;
        }
        private CitiesDataStore()
        {
            Cities = new List<CityGetModel>
            {
                new CityGetModel
                {
                    Id = 1,
                    Name = "Moscow",
                    Description = "The Capital of Russia"
                },
                new CityGetModel
                {
                    Id = 2,
                    Name = "New York",
                    Description = "One of the biggest cities in the world"
                }
            };
        }
    }
}
