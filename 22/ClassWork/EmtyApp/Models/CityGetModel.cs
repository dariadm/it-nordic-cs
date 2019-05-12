using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmtyApp.Models
{
    public class CityGetModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int NumberOfPointsOfInterest{ get; set; }
    }
}
