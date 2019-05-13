using EmtyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmtyApp.DataStore
{
    public class CitiesDataStore: ICititesDataStore
    {
        public List<CityGetModel> Cities{get;private set;}

        public CitiesDataStore()
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
