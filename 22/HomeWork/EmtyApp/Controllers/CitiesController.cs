using EmtyApp.DataStore;
using EmtyApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmtyApp.Controllers
{
    [Route("/api/cities")]
    public class CitiesController : Controller
    {
        [HttpGet()]
        public IActionResult GetCities()
        {
            var citiesDataStore = CitiesDataStore.GetInstance();
            var cities = citiesDataStore.Cities;
            return Ok(cities);
        }

        [HttpGet("{id}", Name = "GetCity")]
        public IActionResult GetCity(int id)
        {
            var citiesDataStore = CitiesDataStore.GetInstance();
            var city = citiesDataStore.Cities
                .Where(c => c.Id == id)
                .FirstOrDefault();

            if (city == null)
            {
                return NotFound();
            }

            return Ok(city);
        }

        [HttpPost()]
        public IActionResult CreateCity([FromBody] CityCreateModel city)
        {
            if (city == null)
            {
                BadRequest();
            }

            var citiesDataStore = CitiesDataStore.GetInstance();
            int newCityId = citiesDataStore.Cities.Max(c => c.Id) + 1;

            var newCity = new CityGetModel
            {
                Id = newCityId,
                Name = city.Name,
                Description = city.Description,
                NumberOfPointsOfInterest = city.NumberOfPointsOfInterest
            };

            citiesDataStore.Cities.Add(newCity);

            return CreatedAtRoute(
                "GetCity",
                new { id = newCityId },
                newCity);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCity(int id, [FromBody] CityCreateModel newCityInfo)
        {
            if (newCityInfo == null)
            {
                BadRequest();
            }

            var citiesDataStore = CitiesDataStore.GetInstance();
            var currentCity = citiesDataStore.Cities
                .Where(c => c.Id == id)
                .FirstOrDefault();

            if (currentCity == null)
            {
                return NotFound();
            }

            currentCity.Name = newCityInfo.Name;
            currentCity.Description = newCityInfo.Description;
            currentCity.NumberOfPointsOfInterest = newCityInfo.NumberOfPointsOfInterest;

            return CreatedAtRoute(
                    "GetCity",
                    currentCity.Id,
                    currentCity);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCity(int id)
        {
            var citiesDataStore = CitiesDataStore.GetInstance();
            var currentCity = citiesDataStore.Cities
                .Where(c => c.Id == id)
                .FirstOrDefault();

            if (currentCity == null)
            {
                return NotFound();
            }

            citiesDataStore.Cities.Remove(currentCity);

            return Ok("Succesfully Deleted!");
        }
    }
}
