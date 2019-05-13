using EmtyApp.DataStore;
using EmtyApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmtyApp.Controllers
{
    [Route("/api/cities")]
    public class CitiesController: Controller
    {
		ILogger<CitiesController> _logger;
		ICititesDataStore _citiesDataStore;

		public CitiesController(ILogger<CitiesController> logger, ICititesDataStore cititesDataStore)
		{
			_logger = logger;
			_citiesDataStore = cititesDataStore; 
		}

        [HttpGet()]
        public IActionResult GetCities()
        {
            var cities = _citiesDataStore.Cities;
            return Ok(cities);
        }

        [HttpGet("{id}", Name = "GetCity")]
        public IActionResult GetCity(int id)
        {
			_logger.LogInformation($"{nameof(GetCities)} called.");

            var city = _citiesDataStore.Cities
                .Where(c => c.Id == id)
                .FirstOrDefault();

            if (city == null)
            {
                return NotFound();
            }

            return Ok(city);
        }

        [HttpPost("/api/cities")]
        public IActionResult CreateCity([FromBody] CityCreateModel city)
        {
            if(city == null)
            {
                return BadRequest();
            }

			if(!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

            int newCityId = _citiesDataStore.Cities.Max(c => c.Id) + 1;

            var newCity = new CityGetModel
            {
                Id = newCityId,
                Name = city.Name,
                Description = city.Description,
                NumberOfPointsOfInterest = city.NumberOfPointsOfInterest
            };

            _citiesDataStore.Cities.Add(newCity);

            return CreatedAtRoute(
                "GetCity",
                new { id = newCityId },
                newCity);
        }
    }
}
