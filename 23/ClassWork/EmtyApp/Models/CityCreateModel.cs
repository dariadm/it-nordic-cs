using EmtyApp.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmtyApp.Models
{
    public class CityCreateModel
    {
		[Required]
		[MaxLength(100, ErrorMessage = "The name of the city shouldn't be longer than 100 characters.")]
		public string Name { get; set; }

		[MaxLength(255, ErrorMessage = "Description of the city shouldn't be longer than 255 characters.")]
		[DifferentValue(OtherProperty = "Name")]
        public string Description { get; set; }

		[Range(0, 100, ErrorMessage = "The NumberOfPointsOfInterest should be between 0 and 100")]
        public int NumberOfPointsOfInterest{ get; set; }
    }
}
